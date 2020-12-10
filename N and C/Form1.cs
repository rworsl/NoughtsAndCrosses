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
        public Form1()
        {
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


        int[] winningRow1 = new int[] { };
        int[] winningRow2 = new int[] { };
        int[] winningRow3 = new int[] { };
        int[] winningRow4 = new int[] { };
        int[] winningRow5 = new int[] { };
        int[] winningRow6 = new int[] { };
        int[] winningRow7 = new int[] { };
        int[] winningRow8 = new int[] { };

        private void SetWinningRows()
        {
            winningRow1.Append(buttonOne);
            winningRow1.Append(buttonTwo);
            winningRow1.Append(buttonThree);
            winningRow2.Append(buttonFour);
            winningRow2.Append(buttonFive);
            winningRow2.Append(buttonSix);
            winningRow3.Append(buttonSeven);
            winningRow3.Append(buttonEight);
            winningRow3.Append(buttonNine);
            winningRow4.Append(buttonOne);
            winningRow4.Append(buttonFour);
            winningRow4.Append(buttonSeven);
            winningRow5.Append(buttonTwo);
            winningRow5.Append(buttonFive);
            winningRow5.Append(buttonEight);
            winningRow6.Append(buttonThree);
            winningRow6.Append(buttonSix);
            winningRow6.Append(buttonNine);
            winningRow7.Append(buttonOne);
            winningRow7.Append(buttonFive);
            winningRow7.Append(buttonNine);
            winningRow8.Append(buttonThree);
            winningRow8.Append(buttonFive);
            winningRow8.Append(buttonSeven);
        }

        private void addPressedButton()
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "X";
            buttonOne = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "X";
            buttonTwo = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "X";
            buttonThree = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "X";
            buttonFour = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";
            buttonFive = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "X";
            buttonSix = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "X";
            buttonSeven = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "X";
            buttonEight = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "X";
            buttonNine = 1;
        }
    }
}
