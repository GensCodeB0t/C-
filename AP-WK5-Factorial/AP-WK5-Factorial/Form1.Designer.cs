namespace AP_WK5_Factorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFact = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a positive integer and click the button\r\nto calculate its factorial value.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter an integer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Factorial";
            // 
            // btnFact
            // 
            this.btnFact.Location = new System.Drawing.Point(131, 109);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(110, 23);
            this.btnFact.TabIndex = 3;
            this.btnFact.Text = "Compute Factorial";
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(131, 74);
            this.txtNum.Name = "txtNum";
            this.txtNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNum.Size = new System.Drawing.Size(110, 20);
            this.txtNum.TabIndex = 4;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFact
            // 
            this.txtFact.Enabled = false;
            this.txtFact.Location = new System.Drawing.Point(131, 147);
            this.txtFact.Name = "txtFact";
            this.txtFact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFact.Size = new System.Drawing.Size(110, 20);
            this.txtFact.TabIndex = 5;
            this.txtFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 191);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Factorial Value Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtFact;
    }
}

