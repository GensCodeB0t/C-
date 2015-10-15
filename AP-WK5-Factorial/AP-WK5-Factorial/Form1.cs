using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_WK5_Factorial
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1, n, nfact = 1;

            // Get input for txtNum text box
            Int32.TryParse(txtNum.Text, out n);

            if (n > 0)
            {
                // If the user input is greater than 10, show an message.
                if (n > 10)
                    MessageBox.Show("Please enter a value < 10");
                else
                {
                    // Create a factorial from the user input using a while loop.
                    while (i <= n)
                    {
                        nfact *= i;
                        i++;
                    }          
                    txtFact.Text = nfact.ToString();
                }
            }
            else
                // If the user input is less than 0, show a message.
                MessageBox.Show("Please enter a value > 0");
        }
    }
}
