using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe1._0
{
    public partial class TicTacToe : Form
    {
        private int[] choice = new int[9];
        private int buttonPressed;
        private bool playerTurn = new bool();
        private Random rand = new Random();

        public TicTacToe()
        {
            InitializeComponent();        
        }

        private void defaultValues() {
            buttonPressed = 0;
            Array.Clear(choice, 0, 9);
            playerTurn = false;
        }

        /********************************* START NEW GAME ************************/
        private void newGame() {
            this.Controls.Clear();
            InitializeComponent();
            defaultValues();
        }

        /******************************** CHECK FOR WINNER **************************/
        private void checkWin()
        {
            int x = playerNumber(playerTurn);

            if (choice[0] == x && choice[1] == x && choice[2] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                else if (choice[0] == x && choice[3] == x && choice[6] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                    else if (choice[0] == x && choice[4] == x && choice[8] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                        else if (choice[1] == x && choice[4] == x && choice[7] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                            else if (choice[2] == x && choice[5] == x && choice[8] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                                else if (choice[2] == x && choice[4] == x && choice[6] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                                    else if (choice[3] == x && choice[4] == x && choice[5] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                                        else if (choice[6] == x && choice[7] == x && choice[8] == x) { MessageBox.Show($"Player {x} wins!!", "TicTacToe1.0"); disableAll(); }
                                            else if (buttonPressed == 9) { MessageBox.Show("It's a Tie!", "TicTacToe1.0"); }
        }

        /*********************************** BUTTON CONTROL *****************************/
        private void buttonClick(int y) {
            buttonPressed++;
            if (playerTurn == false)
            {
                choice[y] = 1;
                checkWin();
            }
            else
            {
                choice[y] = 2;
                checkWin();
            }
            playerTurn = !playerTurn;
            //turnCheck();
        }

        private string result(bool a)
        {
            if (playerTurn == false)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        private void turnCheck()
        {
            if (playerTurn == true)
            {
                //call AI
                aiOpponent();
            }
        }
        private int playerNumber(bool a)
        {
            if (playerTurn == false)
            {
                return 1;
            }
            else return 2;
        }

        private void disableAll()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        /********************************* AI CONTROL *******************/
        /* INCOMPLETE FUNCTION */
        private void aiOpponent() {
            int aiChoice = rand.Next(1, 10);

            if (aiChoice == 1) { if (button1.Enabled == true) { button1.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 2) { if (button2.Enabled == true) { button2.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 3) { if (button3.Enabled == true) { button3.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 4) { if (button4.Enabled == true) { button4.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 5) { if (button5.Enabled == true) { button5.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 6) { if (button6.Enabled == true) { button6.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 7) { if (button7.Enabled == true) { button7.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 8) { if (button8.Enabled == true) { button8.PerformClick(); } else aiOpponent(); }
            else if (aiChoice == 9) { if (button9.Enabled == true) { button9.PerformClick(); } else aiOpponent(); }
            else return;
        }


        private void TicTacToe_Load(object sender, EventArgs e)
        {
            defaultValues();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = result(playerTurn);
            buttonClick(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.Text = result(playerTurn);
            buttonClick(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.Text = result(playerTurn);
            buttonClick(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.Text = result(playerTurn);
            buttonClick(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.Text = result(playerTurn);
            buttonClick(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.Text = result(playerTurn);
            buttonClick(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.Text = result(playerTurn);
            buttonClick(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.Text = result(playerTurn);
            buttonClick(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.Text = result(playerTurn);
            buttonClick(8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
