namespace AP_WK2_InterestCalculator
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
            this.principalTB = new System.Windows.Forms.TextBox();
            this.yearsTB = new System.Windows.Forms.TextBox();
            this.rateTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleIntBtn = new System.Windows.Forms.Button();
            this.compIntBtn = new System.Windows.Forms.Button();
            this.compIntTB = new System.Windows.Forms.TextBox();
            this.simpleIntTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // principalTB
            // 
            this.principalTB.Location = new System.Drawing.Point(22, 45);
            this.principalTB.Name = "principalTB";
            this.principalTB.Size = new System.Drawing.Size(93, 20);
            this.principalTB.TabIndex = 0;
            this.principalTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yearsTB
            // 
            this.yearsTB.Location = new System.Drawing.Point(264, 45);
            this.yearsTB.Name = "yearsTB";
            this.yearsTB.Size = new System.Drawing.Size(93, 20);
            this.yearsTB.TabIndex = 1;
            this.yearsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rateTB
            // 
            this.rateTB.Location = new System.Drawing.Point(143, 45);
            this.rateTB.Name = "rateTB";
            this.rateTB.Size = new System.Drawing.Size(93, 20);
            this.rateTB.TabIndex = 2;
            this.rateTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rate (percent)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Years";
            // 
            // simpleIntBtn
            // 
            this.simpleIntBtn.Location = new System.Drawing.Point(76, 96);
            this.simpleIntBtn.Name = "simpleIntBtn";
            this.simpleIntBtn.Size = new System.Drawing.Size(110, 30);
            this.simpleIntBtn.TabIndex = 6;
            this.simpleIntBtn.Text = "Simple Interest";
            this.simpleIntBtn.UseVisualStyleBackColor = true;
            this.simpleIntBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // compIntBtn
            // 
            this.compIntBtn.Location = new System.Drawing.Point(76, 145);
            this.compIntBtn.Name = "compIntBtn";
            this.compIntBtn.Size = new System.Drawing.Size(110, 30);
            this.compIntBtn.TabIndex = 7;
            this.compIntBtn.Text = "Compound Interest";
            this.compIntBtn.UseVisualStyleBackColor = true;
            this.compIntBtn.Click += new System.EventHandler(this.compIntBtn_Click);
            // 
            // compIntTB
            // 
            this.compIntTB.Location = new System.Drawing.Point(199, 151);
            this.compIntTB.Name = "compIntTB";
            this.compIntTB.Size = new System.Drawing.Size(116, 20);
            this.compIntTB.TabIndex = 8;
            this.compIntTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // simpleIntTB
            // 
            this.simpleIntTB.Location = new System.Drawing.Point(199, 102);
            this.simpleIntTB.Name = "simpleIntTB";
            this.simpleIntTB.Size = new System.Drawing.Size(116, 20);
            this.simpleIntTB.TabIndex = 9;
            this.simpleIntTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 202);
            this.Controls.Add(this.simpleIntTB);
            this.Controls.Add(this.compIntTB);
            this.Controls.Add(this.compIntBtn);
            this.Controls.Add(this.simpleIntBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateTB);
            this.Controls.Add(this.yearsTB);
            this.Controls.Add(this.principalTB);
            this.Name = "Form1";
            this.Text = "Interest Comparison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principalTB;
        private System.Windows.Forms.TextBox yearsTB;
        private System.Windows.Forms.TextBox rateTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button simpleIntBtn;
        private System.Windows.Forms.Button compIntBtn;
        private System.Windows.Forms.TextBox compIntTB;
        private System.Windows.Forms.TextBox simpleIntTB;
    }
}

