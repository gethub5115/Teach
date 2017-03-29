using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> listOfstrings = new List<string>();
        }

        private void m_btn_equal_Click(object sender, EventArgs e)
        {

        }

        private void m_btn_One_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "1";
        }

        private void m_txt_Value_TextChanged(object sender, EventArgs e)
        {
            // Cast text box
            var textbox = (TextBox)(sender);
            // delcare integer
            int i;
            // Check to see if the value in the text box is an integer
            var isAnInteger = int.TryParse(textbox.Text, out i);
            
            if (isAnInteger)
            {
                textbox.BackColor = Color.Black;
            }
            else
            {
                textbox.BackColor = Color.Red;
            }
        }

        private void m_btn_plus_Click(object sender, EventArgs e)
        {

        }
    }

}
