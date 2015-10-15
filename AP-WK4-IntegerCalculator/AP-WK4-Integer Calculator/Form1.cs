using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_WK4_Integer_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int lftOperand, rgtOperand;

            //*****************************************************************
            // Determine whether the user input values are vallid inputs.
            //*****************************************************************
            // If the operand inputs are empty or not integer numbers, show a
            // error message to the user.
            if (txtLeft.Text == null || txtRight.Text == null
                ||!Int32.TryParse(txtLeft.Text,out lftOperand)
                ||!Int32.TryParse(txtRight.Text,out rgtOperand))
            {
                MessageBox.Show("Please enter a integer value for both operands.");
                clearForm();
            }
            // If the user is trying to divide by zero show an error message to
            // the user.
            else if (rgtOperand == 0)
            {
                MessageBox.Show("Dividing by zero is not allowed.");
                clearForm();
            }
            // If the user inputs are valid, perform the correct operation.
            else
            {
                switch (cmbOperator.SelectedIndex)
                {
                    case 0: // addition
                        txtResult.Text = (lftOperand + rgtOperand).ToString();
                        break;
                    case 1: // subtraction
                        txtResult.Text = (lftOperand - rgtOperand).ToString();
                        break;
                    case 2: // multiplication
                        txtResult.Text = (lftOperand * rgtOperand).ToString();
                        break;
                    case 3: // division
                        txtResult.Text = (lftOperand / rgtOperand).ToString();
                        break;
                    case 4: // modulus
                        txtResult.Text = (lftOperand % rgtOperand).ToString();
                        break;
                    default: // if an operator is not selected
                        MessageBox.Show("Please select an operator.");
                        break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the user input and result values
            clearForm();
        }

        //*****************************************************************
        // clearForm() - clear the text values in the txtLeft, txtRight,
        // and txtResult text boxes and clear the selected value in the 
        // operator combo box.
        //*****************************************************************
        private void clearForm()
        { 
            txtLeft.Text = null;
            txtRight.Text = null;
            txtResult.Text = null;
            cmbOperator.SelectedItem = null; 
        }
    }
}
