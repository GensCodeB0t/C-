using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_WK3_Vending_machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            const int qtr = 25, dime = 10, nickel = 5, penny = 1;
            int change, total =0;

            // Get the value from the txtChange text box.
            Int32.TryParse(txtChange.Text,out change);
  
            //****************************************************
            // Convert the number in the txtChange text box into 
            // the smallest combination of coins.
            //****************************************************

            // Quarters
            txtQtr.Text = (change/qtr).ToString();
            total += (change / qtr);
            change %= qtr;

            // Dimes
            txtDime.Text = (change/dime).ToString();
            total += (change / dime);
            change %= dime;

            // Nickels
            txtNickel.Text = (change/nickel).ToString();
            total += (change / nickel);
            change %= nickel;

            // Pennies
            txtPenny.Text = (change/penny).ToString();
            total += (change / penny);
            change %= penny;

            // Total number of coins
            txtCoin.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //****************************************************
            // Clear all the text box text values.
            //****************************************************
            txtQtr.Text = null;
            txtDime.Text = null;
            txtNickel.Text = null;
            txtPenny.Text = null;
            txtCoin.Text = null;
            txtChange.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
