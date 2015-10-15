using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_WK6_Metric_Distance_Converter
{
    public partial class Form1 : Form
    {
        private void ConvertIt(double amt,ref double answ)
        {
            double milliMeters, divisor;

            // Convert the value entered in the txtAmount textbox
            // to a millimeter value.
            switch (cboFrom.SelectedIndex)
            {
                case 0:     // Millimeters
                    milliMeters = amt;
                    break;
                case 1:     // Centimeters
                    milliMeters = amt * 10;
                    break;
                case 2:     // Meters
                    milliMeters = amt * 1000;
                    break;
                case 3:     // Kilometers
                    milliMeters = amt * 1000000;
                    break;
                default:
                    milliMeters = 0;
                    break;
            }

            // Assign the millimeter conversion factor to the divisor
            // variable.
            switch (cboTo.SelectedIndex)
            {
                case 0:     // Inches
                    divisor = 25.4;
                    break;
                case 1:     //Feet
                    divisor = 304.8;
                    break;
                case 2:     // Yards
                    divisor = 914.4;
                    break;
                case 3:     // Miles
                    divisor = 1609344;
                    break;
                default:
                    divisor = 1;
                    break;
            }

            // Assigns the converted value to the refernce variable answer
            answ = (milliMeters / divisor);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double amount, answer = 0;
            Double.TryParse(txtAmount.Text,out amount);
            ConvertIt(amount,ref answer);
            txtAnswer.Text = answer.ToString();
        }
    }
}
