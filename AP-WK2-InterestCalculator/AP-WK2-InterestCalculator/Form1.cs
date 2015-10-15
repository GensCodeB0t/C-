using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_WK2_InterestCalculator
{
    public partial class Form1 : Form
    {

        private int years;
        private float rate;
        private double principal;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get data from text boxes.
            getTBData();
            // Perform simple calculation.
            double simpleIntTotal = principal * (1 + (years * rate));
            // Display result in text box
            simpleIntTB.Text = simpleIntTotal.ToString();
        }
        private void compIntBtn_Click(object sender, EventArgs e)
        {
            // Get data from text boxes.
            getTBData();
            // Perform compound calculation.
            double compIntTotal = principal * Math.Pow((1 + rate), years);
            // Display result in text box
            compIntTB.Text = compIntTotal.ToString();

        }
        //******************************************************************
        // getTBData- Get the data from the text boxes and asign it to the
        // member variables years, rate, and principal.
        //******************************************************************
        private void getTBData()
        {
            // asign member variable years the value of yearsTB textbox.
            Int32.TryParse(yearsTB.Text, out years);
            // asign member variable rate the value of rateTB textbox.
            float.TryParse(rateTB.Text, out rate);
            rate /= 100;
            // asign member variable principal the value of principalTB textbox.
            double.TryParse(principalTB.Text, out principal);
        }
    }
}
