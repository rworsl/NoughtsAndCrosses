using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_and_C
{
    public partial class Form1 : Form
    {
        public void resetGame()
        {
            buttonOne = 0;
            buttonTwo = 0;
            buttonThree = 0;
            buttonFour = 0;
            buttonFive = 0;
            buttonSix = 0;
            buttonSeven = 0;
            buttonEight = 0;
            buttonNine = 0;
            addPressedButton();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        public Form1()
        {
            SetWinningRows();
            InitializeComponent();
        }

        int buttonOne = 0;
        int buttonTwo = 0;
        int buttonThree = 0;
        int buttonFour = 0;
        int buttonFive = 0;
        int buttonSix = 0;
        int buttonSeven = 0;
        int buttonEight = 0;
        int buttonNine = 0;


        int[] winningRow1 = new int[3];
        int[] winningRow2 = new int[3];
        int[] winningRow3 = new int[3];
        int[] winningRow4 = new int[3];
        int[] winningRow5 = new int[3];
        int[] winningRow6 = new int[3];
        int[] winningRow7 = new int[3];
        int[] winningRow8 = new int[3];

        private void SetWinningRows()
        {
            winningRow1[0] = buttonOne;
            winningRow1[1] = buttonTwo;
            winningRow1[2] = buttonThree;
            winningRow2[0] = buttonFour;
            winningRow2[1] = buttonFive;
            winningRow2[2] = buttonSix;
            winningRow3[0] = buttonSeven;
            winningRow3[1] = buttonEight;
            winningRow3[2] = buttonNine;
            winningRow4[0] = buttonOne;
            winningRow4[1] = buttonFour;
            winningRow4[2] = buttonSeven;
            winningRow5[0] = buttonTwo;
            winningRow5[1] = buttonFive;
            winningRow5[2] = buttonEight;
            winningRow6[0] = buttonThree;
            winningRow6[1] = buttonSix;
            winningRow6[2] = buttonNine;
            winningRow7[0] = buttonOne;
            winningRow7[1] = buttonFive;
            winningRow7[2] = buttonNine;
            winningRow8[0] = buttonThree;
            winningRow8[1] = buttonFive;
            winningRow8[2] = buttonSeven;
        }

        private void addPressedButton()
        {
            resetLists();
            SetWinningRows();
            string result = checkWin();
            textBox1.Text = result;
        }
        
        private string checkWin()
        {
            if ((winningRow1[0].Equals(1)) && (winningRow1[1].Equals(1)) && (winningRow1[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow2[0].Equals(1)) && (winningRow2[1].Equals(1)) && (winningRow2[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow3[0].Equals(1)) && (winningRow3[1].Equals(1)) && (winningRow3[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow4[0].Equals(1)) && (winningRow4[1].Equals(1)) && (winningRow4[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow5[0].Equals(1)) && (winningRow5[1].Equals(1)) && (winningRow5[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow6[0].Equals(1)) && (winningRow6[1].Equals(1)) && (winningRow6[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow7[0].Equals(1)) && (winningRow7[1].Equals(1)) && (winningRow7[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow8[0].Equals(1)) && (winningRow8[1].Equals(1)) && (winningRow8[2].Equals(1)))
            {
                return "Player 1 Wins";
            }
            else if ((winningRow1[0].Equals(2)) && (winningRow1[1].Equals(2)) && (winningRow1[2].Equals(2)))
                {
                return "Computer Wins";
            }
            else if ((winningRow2[0].Equals(2)) && (winningRow2[1].Equals(2)) && (winningRow2[2].Equals(2)))
            {
                return "Computer Wins";
            }
            else if ((winningRow3[0].Equals(2)) && (winningRow3[1].Equals(2)) && (winningRow3[2].Equals(2)))
            {
                return "Computer Wins";
            }
            else if ((winningRow4[0].Equals(2)) && (winningRow4[1].Equals(2)) && (winningRow4[2].Equals(2)))
            {
                return "Computer Wins";
            }
            else if ((winningRow5[0].Equals(2)) && (winningRow5[1].Equals(2)) && (winningRow5[2].Equals(2)))
            {
                return "Computer Wins";
            }
            else if ((winningRow6[0].Equals(2)) && (winningRow6[1].Equals(2)) && (winningRow6[2].Equals(2)))
            {
                return "Computer Wins";
            }
            else if ((winningRow7[0].Equals(2)) && (winningRow7[1].Equals(2)) && (winningRow7[2].Equals(2)))
            {
                return "Computer Wins";
            }
            else if ((winningRow8[0].Equals(2)) && (winningRow8[1].Equals(2)) && (winningRow8[2].Equals(2)))
            {
                return "Computer Wins";
            }
            else
            {
                return "undefined";
            }
        }

        private void resetLists()
        {
            winningRow1[0] = 0;
            winningRow1[1] = 0;
            winningRow1[2] = 0;
            winningRow2[0] = 0;
            winningRow2[1] = 0;
            winningRow2[2] = 0;
            winningRow3[0] = 0;
            winningRow3[1] = 0;
            winningRow3[2] = 0;
            winningRow4[0] = 0;
            winningRow4[1] = 0;
            winningRow4[2] = 0;
            winningRow5[0] = 0;
            winningRow5[1] = 0;
            winningRow5[2] = 0;
            winningRow6[0] = 0;
            winningRow6[1] = 0;
            winningRow6[2] = 0;
            winningRow7[0] = 0;
            winningRow7[1] = 0;
            winningRow7[2] = 0;
            winningRow8[0] = 0;
            winningRow8[1] = 0;
            winningRow8[2] = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            buttonOne = 1;
            addPressedButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            buttonTwo = 1;
            addPressedButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            buttonThree = 1;
            addPressedButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            buttonFour = 1;
            addPressedButton();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            buttonFive = 1;
            addPressedButton();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            buttonSix = 1;
            addPressedButton();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            buttonSeven = 1;
            addPressedButton();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            buttonEight = 1;
            addPressedButton();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            buttonNine = 1;
            addPressedButton();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
