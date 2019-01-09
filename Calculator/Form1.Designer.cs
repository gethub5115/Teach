namespace Calculator
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
            this.m_txt_Value = new System.Windows.Forms.TextBox();
            this.m_btn_One = new System.Windows.Forms.Button();
            this.m_btn_plus = new System.Windows.Forms.Button();
            this.m_btn_equal = new System.Windows.Forms.Button();
            this.m_btn_five = new System.Windows.Forms.Button();
            this.m_btn_four = new System.Windows.Forms.Button();
            this.m_btn_three = new System.Windows.Forms.Button();
            this.m_btn_two = new System.Windows.Forms.Button();
            this.m_btn_six = new System.Windows.Forms.Button();
            this.m_btn_seven = new System.Windows.Forms.Button();
            this.m_btn_eight = new System.Windows.Forms.Button();
            this.m_btn_nine = new System.Windows.Forms.Button();
            this.m_btn_zero = new System.Windows.Forms.Button();
            this.m_btn_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_txt_Value
            // 
            this.m_txt_Value.Location = new System.Drawing.Point(12, 12);
            this.m_txt_Value.Name = "m_txt_Value";
            this.m_txt_Value.Size = new System.Drawing.Size(153, 20);
            this.m_txt_Value.TabIndex = 0;
            this.m_txt_Value.TextChanged += new System.EventHandler(this.m_txt_Value_TextChanged);
            this.m_txt_Value.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_Value_KeyUp);
            // 
            // m_btn_One
            // 
            this.m_btn_One.Location = new System.Drawing.Point(13, 94);
            this.m_btn_One.Name = "m_btn_One";
            this.m_btn_One.Size = new System.Drawing.Size(22, 23);
            this.m_btn_One.TabIndex = 1;
            this.m_btn_One.Text = "1";
            this.m_btn_One.UseVisualStyleBackColor = true;
            this.m_btn_One.Click += new System.EventHandler(this.m_btn_One_Click);
            // 
            // m_btn_plus
            // 
            this.m_btn_plus.Location = new System.Drawing.Point(13, 63);
            this.m_btn_plus.Name = "m_btn_plus";
            this.m_btn_plus.Size = new System.Drawing.Size(22, 23);
            this.m_btn_plus.TabIndex = 2;
            this.m_btn_plus.Text = "+";
            this.m_btn_plus.UseVisualStyleBackColor = true;
            this.m_btn_plus.Click += new System.EventHandler(this.m_btn_plus_Click);
            // 
            // m_btn_equal
            // 
            this.m_btn_equal.Location = new System.Drawing.Point(197, 64);
            this.m_btn_equal.Name = "m_btn_equal";
            this.m_btn_equal.Size = new System.Drawing.Size(75, 23);
            this.m_btn_equal.TabIndex = 3;
            this.m_btn_equal.Text = "=";
            this.m_btn_equal.UseVisualStyleBackColor = true;
            this.m_btn_equal.Click += new System.EventHandler(this.m_btn_equal_Click);
            // 
            // m_btn_five
            // 
            this.m_btn_five.Location = new System.Drawing.Point(42, 124);
            this.m_btn_five.Name = "m_btn_five";
            this.m_btn_five.Size = new System.Drawing.Size(22, 23);
            this.m_btn_five.TabIndex = 4;
            this.m_btn_five.Text = "5";
            this.m_btn_five.UseVisualStyleBackColor = true;
            this.m_btn_five.Click += new System.EventHandler(this.m_btn_five_Click);
            // 
            // m_btn_four
            // 
            this.m_btn_four.Location = new System.Drawing.Point(13, 124);
            this.m_btn_four.Name = "m_btn_four";
            this.m_btn_four.Size = new System.Drawing.Size(22, 23);
            this.m_btn_four.TabIndex = 5;
            this.m_btn_four.Text = "4";
            this.m_btn_four.UseVisualStyleBackColor = true;
            this.m_btn_four.Click += new System.EventHandler(this.m_btn_four_Click);
            // 
            // m_btn_three
            // 
            this.m_btn_three.Location = new System.Drawing.Point(70, 94);
            this.m_btn_three.Name = "m_btn_three";
            this.m_btn_three.Size = new System.Drawing.Size(22, 23);
            this.m_btn_three.TabIndex = 6;
            this.m_btn_three.Text = "3";
            this.m_btn_three.UseVisualStyleBackColor = true;
            this.m_btn_three.Click += new System.EventHandler(this.m_btn_three_Click);
            // 
            // m_btn_two
            // 
            this.m_btn_two.Location = new System.Drawing.Point(42, 94);
            this.m_btn_two.Name = "m_btn_two";
            this.m_btn_two.Size = new System.Drawing.Size(22, 23);
            this.m_btn_two.TabIndex = 7;
            this.m_btn_two.Text = "2";
            this.m_btn_two.UseVisualStyleBackColor = true;
            this.m_btn_two.Click += new System.EventHandler(this.m_btn_two_Click);
            // 
            // m_btn_six
            // 
            this.m_btn_six.Location = new System.Drawing.Point(70, 124);
            this.m_btn_six.Name = "m_btn_six";
            this.m_btn_six.Size = new System.Drawing.Size(22, 23);
            this.m_btn_six.TabIndex = 8;
            this.m_btn_six.Text = "6";
            this.m_btn_six.UseVisualStyleBackColor = true;
            this.m_btn_six.Click += new System.EventHandler(this.m_btn_six_Click);
            // 
            // m_btn_seven
            // 
            this.m_btn_seven.Location = new System.Drawing.Point(13, 153);
            this.m_btn_seven.Name = "m_btn_seven";
            this.m_btn_seven.Size = new System.Drawing.Size(22, 23);
            this.m_btn_seven.TabIndex = 9;
            this.m_btn_seven.Text = "7";
            this.m_btn_seven.UseVisualStyleBackColor = true;
            this.m_btn_seven.Click += new System.EventHandler(this.m_btn_seven_Click);
            // 
            // m_btn_eight
            // 
            this.m_btn_eight.Location = new System.Drawing.Point(42, 153);
            this.m_btn_eight.Name = "m_btn_eight";
            this.m_btn_eight.Size = new System.Drawing.Size(22, 23);
            this.m_btn_eight.TabIndex = 10;
            this.m_btn_eight.Text = "8";
            this.m_btn_eight.UseVisualStyleBackColor = true;
            this.m_btn_eight.Click += new System.EventHandler(this.m_btn_eight_Click);
            // 
            // m_btn_nine
            // 
            this.m_btn_nine.Location = new System.Drawing.Point(70, 153);
            this.m_btn_nine.Name = "m_btn_nine";
            this.m_btn_nine.Size = new System.Drawing.Size(22, 23);
            this.m_btn_nine.TabIndex = 11;
            this.m_btn_nine.Text = "9";
            this.m_btn_nine.UseVisualStyleBackColor = true;
            this.m_btn_nine.Click += new System.EventHandler(this.m_btn_nine_Click);
            // 
            // m_btn_zero
            // 
            this.m_btn_zero.Location = new System.Drawing.Point(42, 183);
            this.m_btn_zero.Name = "m_btn_zero";
            this.m_btn_zero.Size = new System.Drawing.Size(22, 23);
            this.m_btn_zero.TabIndex = 12;
            this.m_btn_zero.Text = "0";
            this.m_btn_zero.UseVisualStyleBackColor = true;
            this.m_btn_zero.Click += new System.EventHandler(this.m_btn_zero_Click);
            // 
            // m_btn_minus
            // 
            this.m_btn_minus.Location = new System.Drawing.Point(42, 63);
            this.m_btn_minus.Name = "m_btn_minus";
            this.m_btn_minus.Size = new System.Drawing.Size(22, 23);
            this.m_btn_minus.TabIndex = 13;
            this.m_btn_minus.Text = "-";
            this.m_btn_minus.UseVisualStyleBackColor = true;
            this.m_btn_minus.Click += new System.EventHandler(this.m_btn_minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_btn_minus);
            this.Controls.Add(this.m_btn_zero);
            this.Controls.Add(this.m_btn_nine);
            this.Controls.Add(this.m_btn_eight);
            this.Controls.Add(this.m_btn_seven);
            this.Controls.Add(this.m_btn_six);
            this.Controls.Add(this.m_btn_two);
            this.Controls.Add(this.m_btn_three);
            this.Controls.Add(this.m_btn_four);
            this.Controls.Add(this.m_btn_five);
            this.Controls.Add(this.m_btn_equal);
            this.Controls.Add(this.m_btn_plus);
            this.Controls.Add(this.m_btn_One);
            this.Controls.Add(this.m_txt_Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_Value;
        private System.Windows.Forms.Button m_btn_One;
        private System.Windows.Forms.Button m_btn_plus;
        private System.Windows.Forms.Button m_btn_equal;
        private System.Windows.Forms.Button m_btn_five;
        private System.Windows.Forms.Button m_btn_four;
        private System.Windows.Forms.Button m_btn_three;
        private System.Windows.Forms.Button m_btn_two;
        private System.Windows.Forms.Button m_btn_six;
        private System.Windows.Forms.Button m_btn_seven;
        private System.Windows.Forms.Button m_btn_eight;
        private System.Windows.Forms.Button m_btn_nine;
        private System.Windows.Forms.Button m_btn_zero;
        private System.Windows.Forms.Button m_btn_minus;
    }
}

