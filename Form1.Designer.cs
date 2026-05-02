namespace CS_3020_FInal_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RollButton = new Button();
            DiceType = new GroupBox();
            rbCustom = new RadioButton();
            rbD20 = new RadioButton();
            rbD6 = new RadioButton();
            numSides = new NumericUpDown();
            ResultsLabel = new Label();
            HistoryBox = new ListBox();
            StatsLabel = new Label();
            SaveHistoryB = new Button();
            DiceType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSides).BeginInit();
            SuspendLayout();
            // 
            // RollButton
            // 
            RollButton.Location = new Point(42, 273);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(94, 29);
            RollButton.TabIndex = 0;
            RollButton.Text = "Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // DiceType
            // 
            DiceType.Controls.Add(rbCustom);
            DiceType.Controls.Add(rbD20);
            DiceType.Controls.Add(rbD6);
            DiceType.Location = new Point(42, 69);
            DiceType.Name = "DiceType";
            DiceType.Size = new Size(250, 125);
            DiceType.TabIndex = 1;
            DiceType.TabStop = false;
            DiceType.Text = "Dice Type";
            DiceType.Enter += groupBox1_Enter;
            // 
            // rbCustom
            // 
            rbCustom.AutoSize = true;
            rbCustom.Location = new Point(85, 88);
            rbCustom.Name = "rbCustom";
            rbCustom.Size = new Size(80, 24);
            rbCustom.TabIndex = 2;
            rbCustom.TabStop = true;
            rbCustom.Text = "Custom";
            rbCustom.UseVisualStyleBackColor = true;
            rbCustom.CheckedChanged += rbCustom_CheckedChanged;
            // 
            // rbD20
            // 
            rbD20.AutoSize = true;
            rbD20.Location = new Point(85, 58);
            rbD20.Name = "rbD20";
            rbD20.Size = new Size(158, 24);
            rbD20.TabIndex = 1;
            rbD20.TabStop = true;
            rbD20.Text = "20-Sided Die (D20)";
            rbD20.UseVisualStyleBackColor = true;
            rbD20.CheckedChanged += rbD20_CheckedChanged;
            // 
            // rbD6
            // 
            rbD6.AutoSize = true;
            rbD6.Location = new Point(85, 31);
            rbD6.Name = "rbD6";
            rbD6.Size = new Size(142, 24);
            rbD6.TabIndex = 0;
            rbD6.TabStop = true;
            rbD6.Text = "6-Sided Die (D6)";
            rbD6.UseVisualStyleBackColor = true;
            rbD6.CheckedChanged += rbD6_CheckedChanged;
            // 
            // numSides
            // 
            numSides.Location = new Point(311, 157);
            numSides.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numSides.Name = "numSides";
            numSides.Size = new Size(67, 27);
            numSides.TabIndex = 2;
            numSides.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Location = new Point(621, 30);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(55, 20);
            ResultsLabel.TabIndex = 3;
            ResultsLabel.Text = "Results";
            // 
            // HistoryBox
            // 
            HistoryBox.FormattingEnabled = true;
            HistoryBox.Location = new Point(545, 69);
            HistoryBox.Name = "HistoryBox";
            HistoryBox.Size = new Size(207, 284);
            HistoryBox.TabIndex = 4;
            // 
            // StatsLabel
            // 
            StatsLabel.AutoSize = true;
            StatsLabel.Location = new Point(597, 356);
            StatsLabel.Name = "StatsLabel";
            StatsLabel.Size = new Size(41, 20);
            StatsLabel.TabIndex = 5;
            StatsLabel.Text = "Stats";
            StatsLabel.Click += label2_Click;
            // 
            // SaveHistoryB
            // 
            SaveHistoryB.Location = new Point(587, 424);
            SaveHistoryB.Name = "SaveHistoryB";
            SaveHistoryB.Size = new Size(114, 30);
            SaveHistoryB.TabIndex = 6;
            SaveHistoryB.Text = "Save Results";
            SaveHistoryB.UseVisualStyleBackColor = true;
            SaveHistoryB.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(SaveHistoryB);
            Controls.Add(StatsLabel);
            Controls.Add(HistoryBox);
            Controls.Add(ResultsLabel);
            Controls.Add(numSides);
            Controls.Add(DiceType);
            Controls.Add(RollButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DiceType.ResumeLayout(false);
            DiceType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSides).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RollButton;
        private GroupBox DiceType;
        private RadioButton rbCustom;
        private RadioButton rbD20;
        private RadioButton rbD6;
        private NumericUpDown numSides;
        private Label ResultsLabel;
        private ListBox HistoryBox;
        private Label StatsLabel;
        private Button SaveHistoryB;
    }
}
