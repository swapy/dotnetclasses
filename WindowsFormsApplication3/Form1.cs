using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{

    public partial class Form1 : Form
    {
        string input = string.Empty;
        char operation;
        string operand1, operand2;
        bool hasIterated = false;
        int result = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        private void onNumClick(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;

            input += buttonClicked.Text;
            MessageBox.Show(input);
            txtResult.Text = input;
        }

     
        private void onOperatorClick(object sender, EventArgs e)
        {
            if (hasIterated)
                operand2 = input;
            else
                operand1 = input;

            MessageBox.Show("operand 1 is " + input);
            Button buttonClicked = (Button)sender;
            operation = Convert.ToChar(buttonClicked.Text);
            input = string.Empty;
        }

   
        private void onEqualToClick(object sender, EventArgs e)
        {
            hasIterated = true;

            operand2 = input;
            int op1 = Convert.ToInt32(operand1);
            int op2 = Convert.ToInt32(operand2);

            if (operation == '+')
            {
                result = op1 + op2;
            }

            if (operation == '-')
            {
                result = op1 - op2;
            }

            if (operation == '*')
            {
                result = op1 * op2;
            }

            if (operation == '/')
            {
                result = op1 / op2;
            }

            input = string.Empty;
            txtResult.Text = result.ToString();
            operand1 = result.ToString();
            operand2 = string.Empty;

        }


    }
}
