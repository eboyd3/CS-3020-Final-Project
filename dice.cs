using System.Linq;

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