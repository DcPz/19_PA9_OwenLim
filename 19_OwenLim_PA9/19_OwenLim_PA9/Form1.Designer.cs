﻿namespace _19_OwenLim_PA9
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
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Converted = new System.Windows.Forms.TextBox();
            this.rb_US = new System.Windows.Forms.RadioButton();
            this.rb_Yen = new System.Windows.Forms.RadioButton();
            this.btn_Convert_Click = new System.Windows.Forms.Button();
            this.btn_Clear_Click = new System.Windows.Forms.Button();
            this.rb_Ringgit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Converted Amount";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(241, 84);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(188, 20);
            this.txt_Amount.TabIndex = 3;
            this.txt_Amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Converted
            // 
            this.txt_Converted.AcceptsReturn = true;
            this.txt_Converted.Location = new System.Drawing.Point(241, 199);
            this.txt_Converted.Name = "txt_Converted";
            this.txt_Converted.Size = new System.Drawing.Size(188, 20);
            this.txt_Converted.TabIndex = 4;
            this.txt_Converted.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rb_US
            // 
            this.rb_US.AutoSize = true;
            this.rb_US.Location = new System.Drawing.Point(241, 125);
            this.rb_US.Name = "rb_US";
            this.rb_US.Size = new System.Drawing.Size(75, 17);
            this.rb_US.TabIndex = 5;
            this.rb_US.TabStop = true;
            this.rb_US.Text = "US Dollars";
            this.rb_US.UseVisualStyleBackColor = true;
            this.rb_US.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_Yen
            // 
            this.rb_Yen.AutoSize = true;
            this.rb_Yen.Location = new System.Drawing.Point(241, 149);
            this.rb_Yen.Name = "rb_Yen";
            this.rb_Yen.Size = new System.Drawing.Size(93, 17);
            this.rb_Yen.TabIndex = 6;
            this.rb_Yen.TabStop = true;
            this.rb_Yen.Text = "Japanese Yen";
            this.rb_Yen.UseVisualStyleBackColor = true;
            this.rb_Yen.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btn_Convert_Click
            // 
            this.btn_Convert_Click.Location = new System.Drawing.Point(465, 168);
            this.btn_Convert_Click.Name = "btn_Convert_Click";
            this.btn_Convert_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert_Click.TabIndex = 7;
            this.btn_Convert_Click.Text = "Convert";
            this.btn_Convert_Click.UseVisualStyleBackColor = true;
            this.btn_Convert_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Clear_Click
            // 
            this.btn_Clear_Click.Location = new System.Drawing.Point(465, 195);
            this.btn_Clear_Click.Name = "btn_Clear_Click";
            this.btn_Clear_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear_Click.TabIndex = 8;
            this.btn_Clear_Click.Text = "Clear";
            this.btn_Clear_Click.UseVisualStyleBackColor = true;
            this.btn_Clear_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // rb_Ringgit
            // 
            this.rb_Ringgit.AutoSize = true;
            this.rb_Ringgit.Location = new System.Drawing.Point(241, 172);
            this.rb_Ringgit.Name = "rb_Ringgit";
            this.rb_Ringgit.Size = new System.Drawing.Size(102, 17);
            this.rb_Ringgit.TabIndex = 9;
            this.rb_Ringgit.TabStop = true;
            this.rb_Ringgit.Text = "Malaysia Ringgit";
            this.rb_Ringgit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 329);
            this.Controls.Add(this.rb_Ringgit);
            this.Controls.Add(this.btn_Clear_Click);
            this.Controls.Add(this.btn_Convert_Click);
            this.Controls.Add(this.rb_Yen);
            this.Controls.Add(this.rb_US);
            this.Controls.Add(this.txt_Converted);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Converted;
        private System.Windows.Forms.RadioButton rb_US;
        private System.Windows.Forms.RadioButton rb_Yen;
        private System.Windows.Forms.Button btn_Convert_Click;
        private System.Windows.Forms.Button btn_Clear_Click;
        private System.Windows.Forms.RadioButton rb_Ringgit;
    }
}

