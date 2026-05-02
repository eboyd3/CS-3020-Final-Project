using System.Linq;
namespace CS_3020_FInal_Project
{
    public partial class Form1 : Form
    {
        private DiceSession session = new DiceSession();
        public Form1()
        {
            InitializeComponent();
            rbD6.Checked = true;        // default selection
            numSides.Enabled = false;   // disable custom input by default
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            session = new DiceSession(); // fresh session each roll

            // add the right die based on selection
            if (rbD6.Checked)
                session.AddDie(new D6());
            else if (rbD20.Checked)
                session.AddDie(new D20());
            else if (rbCustom.Checked)
                session.AddDie(new CustomDie((int)numSides.Value));

            // roll and show result
            List<int> results = session.RollAll();
            ResultsLabel.Text = "Results: " + string.Join(", ", results);

            // add to history box
            HistoryBox.Items.Add("Rolled: " + string.Join(", ", results));

            // update stats
            StatsLabel.Text = $"Total Rolls: {HistoryBox.Items.Count}\n" +
                            $"Last Roll: {string.Join(", ", results)}";
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            numSides.Enabled = rbCustom.Checked;
        }

        private void rbD20_CheckedChanged(object sender, EventArgs e)
        {
            numSides.Enabled = false;
        }

        private void rbD6_CheckedChanged(object sender, EventArgs e)
        {
            numSides.Enabled = false;
        }
    }


    //Parent class representing a generic dice that accepts a variable number of sides
    class Dice
    {
        protected int sides;
        private Random rng = new Random();

        public Dice(int sides)
        {
            this.sides = sides;
        }

        public int Roll()
        {
            return rng.Next(1, sides + 1);
        }
    }//end class Dice

    //A class representing a 6-sided die
    class D6 : Dice
    {
        public D6() : base(6)
        {
        }
    }//end class D6

    //A class representing a 20-sided die
    class D20 : Dice
    {
        public D20() : base(20)
        {
        }
    }//end class D20

    //A class representing a custom-sided die
    class CustomDie : Dice
    {
        public CustomDie(int sides) : base(sides)
        {
        }
    }//end class CustomDie

    //A class representing a session of dice rolls
    class DiceSession
    {
        private List<Dice> dice = new List<Dice>();
        private List<int> rollHistory = new List<int>();
        private int totalRolls = 0;

        public void AddDie(Dice die)
        {
            dice.Add(die);
        }

        public List<int> RollAll()
        {
            List<int> results = new List<int>();
            foreach (Dice d in dice)
            {
                int result = d.Roll();
                results.Add(result);
                rollHistory.Add(result);
                totalRolls++;
            }
            return results;
        }

        public int GetTotalRolls() { return totalRolls; }
        public List<int> GetHistory() { return rollHistory; }

        public double GetAverage()
        {
            if (rollHistory.Count == 0) return 0;
            return rollHistory.Average();
        }

        public int GetMostFrequent()
        {
            if (rollHistory.Count == 0) return 0;
            return rollHistory
                //groups like values
                .GroupBy(x => x)
                //orders the groups by their count in descending order
                .OrderByDescending(g => g.Count())
                //returns the first group (the most frequent value)
                .First().Key;
        }

        public Dictionary<int, int> GetFrequencies()
        {
            return rollHistory
                //groups like values
                .GroupBy(x => x)
                //converts the groups to a dictionary, the roll value becoming the key and the count becoming the value
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }//end class DiceSession
}


