using System.Data.SqlTypes;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private string playerName;
        private Random rand = new Random();
        private bool turn = true; // true = player's turn, false = computer's turn 
        private bool isPlayerXTurn = true;
        private int playerWinCounter = 0;
        private int computerWinCounter = 0;
        private int tieCounter = 0;
        private int buttonCountdown = 9;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets name from user and greets them.
        /// </summary>
        /// <param name="sender">The button that was clicked, passed as an object</param>
        /// <param name="e">Event argument for button click event</param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            // Get the name from TextBox
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                playerName = nameTextBox.Text;
            }
            else
            {
                playerName = "Player"; // Default name if not exist
            }

            // Display the greeting message with name on form
            greetingLabel.Text = ($"Welcome, {playerName}! Let's play Tic Tac Toe!");

            // Determine first player
            FirstPlayer();

        }

        private void button_Click(object sender, EventArgs e)
        {
            //if (!turn) return; // player can't input during computer's turn

            Button button = (Button)sender;
            if (button.Text != "") return; // prevent multiple moves on the same cell

            if (isPlayerXTurn == true)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }


            turn = !turn;
            button.Enabled = false; // Disables the button
            buttonCountdown--; // Decrease the number of buttons
            CheckGame(); // Check if the game is over
            ComputerMove();
        }

        /// <summary>
        /// Computer randomly select an available button and marks
        /// </summary>
        private void ComputerMove()
        {

            if (turn) return; // computer's can't input during players's turn


            List<Button> buttons = new List<Button> { button1, button2, button3, button4,
            button5, button6, button7,  button8, button9 };


            int number;

            number = rand.Next(9);

            if (buttons[number].Text == "")
            {
                if (isPlayerXTurn != true)
                {
                    buttons[number].Text = "X";
                }
                else
                {
                    buttons[number].Text = "O";
                }

                buttonCountdown--; // Decrease the number of buttons
                CheckGame(); // Check if the game is over
                buttons[number].Enabled = false; // Disables the button
                turn = !turn;
            }
            else
            {
                ComputerMove();
            }

    
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the form
        }

        /// <summary>
        /// Randomly generates first player and assign them as X
        /// </summary>
        private void FirstPlayer()
        {

            // playerName is first if generate 0, 
            // else generated 1 and computer is first 
            if (isPlayerXTurn = rand.Next(2) == 0) // equal chance of turn
            {
                isPlayerXTurn = true;
                turn = true;
                playerTurnLabel.Text = $"{playerName} goes first as X.";
            }
            else
            {
                isPlayerXTurn = false;
                turn = false;
                playerTurnLabel.Text = "Computer goes first as X.";
                ComputerMove();
            }
        }

        private void CheckGame()
        {

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                if (isPlayerXTurn == true)
                {
                    playerWinCounter++;
                    winResult.Text = "You win!"; // Display the result
                    playerWins.Text = "Player Wins: " + playerWinCounter;
                    NewGame();
                }
                else
                {
                    computerWinCounter++;
                    winResult.Text = "Computer wins :("; // Display the result
                    compWins.Text = "Comp Wins: " + computerWinCounter;
                    NewGame();
                }

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                if (isPlayerXTurn == true)
                {
                    computerWinCounter++;
                    winResult.Text = "Computer wins :("; // Display the result
                    compWins.Text = "Comp Wins: " + computerWinCounter;
                    NewGame();
                }
                else
                {
                    playerWinCounter++;
                    winResult.Text = "You win!"; // Display the result
                    playerWins.Text = "Player Wins: " + playerWinCounter;
                    NewGame();
                }

            }
            else if (buttonCountdown == 0)
            {
                winResult.Text = "It's a tie!"; // Display the result
                tieCounter++;
                tieCount.Text = "Tie: " + tieCounter;

                NewGame();
            }
        }

        private void NewGame()
        {
            buttonCountdown = 9;
            button1.Text = button2.Text = button3.Text = button4.Text =
            button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";

            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled
            = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;

            FirstPlayer();
        }

        private void ngButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
