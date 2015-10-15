using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_WK8_Parallel_Arrays
{
    public partial class Form1 : Form
    {
        // Create parallel arrays.
        private double[] score = { 45, 65, 11, 98, 66, 56, 77, 78, 56, 56, 87, 71, 78, 90, 78, 76, 75, 72, 79, 83 };
        private int[] id = { 100, 143, 132, 144, 122, 127, 111, 113, 120, 131, 109, 101, 112, 121, 115, 105, 125, 102, 116, 108 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int inputID;
            string scoreResult = "ID not found!"; 
            
            // Search for an integer in txtID.
            if (!Int32.TryParse(txtID.Text, out inputID))
                // Could not find an ID number in the user input.
                MessageBox.Show("Invalid ID");
            else
                // Search the array for the user input ID.
                for (int i = 0; i <= score.GetUpperBound(0); i++)
                {
                    if (id[i] == inputID)
                    {
                        scoreResult = score[i].ToString();
                        break;
                    }
                }

            // Display the Score result in the txtScore textbox.
            txtScore.Text = scoreResult;
        }
    }
}
