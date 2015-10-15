namespace AP_WK3_Vending_machine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtr = new System.Windows.Forms.TextBox();
            this.txtDime = new System.Windows.Forms.TextBox();
            this.txtNickel = new System.Windows.Forms.TextBox();
            this.txtPenny = new System.Windows.Forms.TextBox();
            this.txtCoin = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(176, 14);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(69, 20);
            this.txtChange.TabIndex = 0;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount of change (0-99 cents)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of quarters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of dimes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of nickels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of pennies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total coins";
            // 
            // txtQtr
            // 
            this.txtQtr.Enabled = false;
            this.txtQtr.Location = new System.Drawing.Point(176, 108);
            this.txtQtr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtQtr.Name = "txtQtr";
            this.txtQtr.Size = new System.Drawing.Size(69, 20);
            this.txtQtr.TabIndex = 7;
            this.txtQtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDime
            // 
            this.txtDime.Enabled = false;
            this.txtDime.Location = new System.Drawing.Point(176, 137);
            this.txtDime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDime.Name = "txtDime";
            this.txtDime.Size = new System.Drawing.Size(69, 20);
            this.txtDime.TabIndex = 8;
            this.txtDime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNickel
            // 
            this.txtNickel.Enabled = false;
            this.txtNickel.Location = new System.Drawing.Point(176, 168);
            this.txtNickel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNickel.Name = "txtNickel";
            this.txtNickel.Size = new System.Drawing.Size(69, 20);
            this.txtNickel.TabIndex = 9;
            this.txtNickel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPenny
            // 
            this.txtPenny.Enabled = false;
            this.txtPenny.Location = new System.Drawing.Point(176, 196);
            this.txtPenny.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPenny.Name = "txtPenny";
            this.txtPenny.Size = new System.Drawing.Size(69, 20);
            this.txtPenny.TabIndex = 10;
            this.txtPenny.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCoin
            // 
            this.txtCoin.Enabled = false;
            this.txtCoin.Location = new System.Drawing.Point(176, 235);
            this.txtCoin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Size = new System.Drawing.Size(69, 20);
            this.txtCoin.TabIndex = 11;
            this.txtCoin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(92, 51);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(68, 32);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 51);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 32);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 272);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtCoin);
            this.Controls.Add(this.txtPenny);
            this.Controls.Add(this.txtNickel);
            this.Controls.Add(this.txtDime);
            this.Controls.Add(this.txtQtr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChange);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Vending Machine Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtr;
        private System.Windows.Forms.TextBox txtDime;
        private System.Windows.Forms.TextBox txtNickel;
        private System.Windows.Forms.TextBox txtPenny;
        private System.Windows.Forms.TextBox txtCoin;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
    }
}

