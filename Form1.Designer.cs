namespace TicTacToe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            prompt = new Label();
            nameTextBox = new TextBox();
            startBtn = new Button();
            greetingLabel = new Label();
            ngButton = new Button();
            exitBtn = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            playerTurnLabel = new Label();
            playerWins = new Label();
            tieCount = new Label();
            winResult = new Label();
            compWins = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.12121F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2525253F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2525253F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2525253F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.121212F));
            tableLayoutPanel1.Controls.Add(prompt, 0, 0);
            tableLayoutPanel1.Controls.Add(nameTextBox, 2, 0);
            tableLayoutPanel1.Controls.Add(startBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(greetingLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(ngButton, 2, 1);
            tableLayoutPanel1.Controls.Add(exitBtn, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 1, 6);
            tableLayoutPanel1.Controls.Add(button8, 2, 6);
            tableLayoutPanel1.Controls.Add(button9, 3, 6);
            tableLayoutPanel1.Controls.Add(button4, 1, 5);
            tableLayoutPanel1.Controls.Add(button5, 2, 5);
            tableLayoutPanel1.Controls.Add(button6, 3, 5);
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Controls.Add(button2, 2, 4);
            tableLayoutPanel1.Controls.Add(button3, 3, 4);
            tableLayoutPanel1.Controls.Add(playerTurnLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(playerWins, 1, 7);
            tableLayoutPanel1.Controls.Add(tieCount, 2, 7);
            tableLayoutPanel1.Controls.Add(winResult, 1, 8);
            tableLayoutPanel1.Controls.Add(compWins, 3, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.22229338F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.50858355F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.61684847F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.672288F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9152718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.9152718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.70561F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.22229338F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.22154331F));
            tableLayoutPanel1.Size = new Size(514, 604);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // prompt
            // 
            prompt.Anchor = AnchorStyles.None;
            prompt.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(prompt, 2);
            prompt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prompt.Location = new Point(5, 4);
            prompt.Margin = new Padding(3, 4, 3, 4);
            prompt.Name = "prompt";
            prompt.Padding = new Padding(6, 0, 0, 0);
            prompt.Size = new Size(180, 28);
            prompt.TabIndex = 11;
            prompt.Text = "Enter your name: ";
            // 
            // nameTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(nameTextBox, 3);
            nameTextBox.Location = new Point(194, 7);
            nameTextBox.Margin = new Padding(3, 7, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(284, 27);
            nameTextBox.TabIndex = 12;
            // 
            // startBtn
            // 
            startBtn.Anchor = AnchorStyles.None;
            startBtn.Location = new Point(69, 44);
            startBtn.Margin = new Padding(3, 7, 3, 4);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(114, 34);
            startBtn.TabIndex = 9;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(greetingLabel, 3);
            greetingLabel.Dock = DockStyle.Fill;
            greetingLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetingLabel.ForeColor = Color.Black;
            greetingLabel.Location = new Point(65, 86);
            greetingLabel.Margin = new Padding(3, 4, 3, 4);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(381, 25);
            greetingLabel.TabIndex = 13;
            greetingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ngButton
            // 
            ngButton.Anchor = AnchorStyles.None;
            ngButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngButton.Location = new Point(198, 44);
            ngButton.Margin = new Padding(3, 7, 3, 4);
            ngButton.Name = "ngButton";
            ngButton.Size = new Size(114, 34);
            ngButton.TabIndex = 10;
            ngButton.Text = "New Game";
            ngButton.UseVisualStyleBackColor = true;
            ngButton.Click += ngButton_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(323, 44);
            exitBtn.Margin = new Padding(3, 7, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(114, 34);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(65, 405);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(121, 117);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(194, 405);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(121, 117);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(323, 405);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(121, 117);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(65, 279);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(121, 118);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(194, 279);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(121, 118);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(323, 279);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(121, 118);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(65, 153);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 118);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(194, 153);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(121, 118);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(323, 153);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(121, 118);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // playerTurnLabel
            // 
            playerTurnLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(playerTurnLabel, 3);
            playerTurnLabel.Dock = DockStyle.Fill;
            playerTurnLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerTurnLabel.Location = new Point(65, 119);
            playerTurnLabel.Margin = new Padding(3, 4, 3, 4);
            playerTurnLabel.Name = "playerTurnLabel";
            playerTurnLabel.Size = new Size(381, 26);
            playerTurnLabel.TabIndex = 15;
            playerTurnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerWins
            // 
            playerWins.AutoSize = true;
            playerWins.Font = new Font("Segoe UI", 9.5F);
            playerWins.Location = new Point(65, 526);
            playerWins.Name = "playerWins";
            playerWins.Size = new Size(95, 21);
            playerWins.TabIndex = 16;
            playerWins.Text = "Player Wins:";
            // 
            // tieCount
            // 
            tieCount.AutoSize = true;
            tieCount.Font = new Font("Segoe UI", 9.5F);
            tieCount.Location = new Point(194, 526);
            tieCount.Name = "tieCount";
            tieCount.Size = new Size(40, 21);
            tieCount.TabIndex = 17;
            tieCount.Text = "Ties:";
            // 
            // winResult
            // 
            winResult.AutoSize = true;
            winResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            winResult.ForeColor = SystemColors.ControlText;
            winResult.Location = new Point(65, 563);
            winResult.Name = "winResult";
            winResult.Size = new Size(0, 20);
            winResult.TabIndex = 19;
            // 
            // compWins
            // 
            compWins.AutoSize = true;
            compWins.Font = new Font("Segoe UI", 9.5F);
            compWins.Location = new Point(323, 526);
            compWins.Name = "compWins";
            compWins.Size = new Size(80, 21);
            compWins.TabIndex = 18;
            compWins.Text = "Cpu Wins:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(514, 604);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(588, 651);
            MinimumSize = new Size(498, 546);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button startBtn;
        private Button ngButton;
        private Label prompt;
        private TextBox nameTextBox;
        private Label greetingLabel;
        private Button exitBtn;
        private Label label1;
        private Label playerTurnLabel;
        private Label playerWins;
        private Label tieCount;
        private Label compWins;
        private Label winResult;
    }
}
