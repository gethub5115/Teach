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
            this.SuspendLayout();
            // 
            // m_txt_Value
            // 
            this.m_txt_Value.Location = new System.Drawing.Point(13, 13);
            this.m_txt_Value.Name = "m_txt_Value";
            this.m_txt_Value.Size = new System.Drawing.Size(115, 20);
            this.m_txt_Value.TabIndex = 0;
            this.m_txt_Value.TextChanged += new System.EventHandler(this.m_txt_Value_TextChanged);
            // 
            // m_btn_One
            // 
            this.m_btn_One.Location = new System.Drawing.Point(13, 64);
            this.m_btn_One.Name = "m_btn_One";
            this.m_btn_One.Size = new System.Drawing.Size(27, 23);
            this.m_btn_One.TabIndex = 1;
            this.m_btn_One.Text = "1";
            this.m_btn_One.UseVisualStyleBackColor = true;
            this.m_btn_One.Click += new System.EventHandler(this.m_btn_One_Click);
            // 
            // m_btn_plus
            // 
            this.m_btn_plus.Location = new System.Drawing.Point(56, 64);
            this.m_btn_plus.Name = "m_btn_plus";
            this.m_btn_plus.Size = new System.Drawing.Size(24, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

