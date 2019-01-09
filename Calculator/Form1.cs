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
        private readonly Stack<IItem> m_stack_formula;

        public Form1()
        {
            InitializeComponent();

            m_stack_formula = new Stack<IItem>();
        }

        private IEnumerable<IItem> PopAllItems()
        {
            while(m_stack_formula.Count > 0)
            {
                yield return m_stack_formula.Pop();
            }
        }

        private void m_btn_equal_Click(object sender, EventArgs e)
        {
            retry:
            bool gotValue = TryStackValue(m_stack_formula);

            if (gotValue)
            {
                decimal? total = null;

                IOperation currentOperation = null;

                foreach(var currentItem in PopAllItems())
                {
                    if(currentItem is IOperation)
                    {
                        currentOperation = currentItem as IOperation;
                        continue;
                    }

                    if(currentItem is DecimalVariable)
                    {
                        var variable = (DecimalVariable)currentItem;

                        if (total is null)
                        {
                            total = variable.Value;
                            continue;
                        }
                        else
                        {
                            switch(currentOperation.Value)
                            {
                                case OperationValue.Addition:
                                    total += variable.Value;
                                    continue;
                                case OperationValue.Substraction:
                                    total -= variable.Value;
                                    continue;
                            }
                        }
                    }
                }

                m_txt_Value.Text = total.Value.ToString();
            }
            else
            {
                string message = "";
                string caption = "";

                var result = MessageBox.Show(message, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                switch (result)
                {
                    case DialogResult.Retry:
                        goto retry;
                    case DialogResult.Cancel:
                        return;
                }
            }
        }

        private void m_btn_plus_Click(object sender, EventArgs e)
        {
            bool gotValue = TryStackValue(m_stack_formula);

            if (gotValue)
            {
                m_stack_formula.Push(new AdditionOperation());
            }
        }

        private bool TryStackValue(Stack<IItem> stack)
        {
            var stringValue = m_txt_Value.Text;
            var gotValue = false;

            if (decimal.TryParse(stringValue, out decimal value))
            {
                stack.Push(new DecimalVariable
                {
                    Value = value
                });
                gotValue = true;

                m_txt_Value.Text = string.Empty;
            }

            return gotValue;
        }

        private void m_btn_minus_Click(object sender, EventArgs e)
        {
            bool gotValue = TryStackValue(m_stack_formula);

            if (gotValue)
            {
                m_stack_formula.Push(new SubtractionOperation());
            }
        }

        private void m_txt_Value_TextChanged(object sender, EventArgs e)
        {
            // Cast text box
            var textbox = (TextBox)(sender);

            if(textbox.Text.IndexOf("+") > 0)
            {
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
                m_btn_plus_Click(null, null);
            }
            else if (textbox.Text.IndexOf("=") > 0)
            {
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
                m_btn_equal_Click(null, null);
            }
            else if (textbox.Text.IndexOf("-") > 0)
            {
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
                m_btn_minus_Click(null, null);
            }

            // delcare integer
            int i;
            // Check to see if the value in the text box is an integer
            var isAnInteger = int.TryParse(textbox.Text, out i);

            if (isAnInteger || string.IsNullOrEmpty(textbox.Text))
            {
                textbox.BackColor = Color.White;
                textbox.ForeColor = Color.Black;
            }
            else
            {
                textbox.BackColor = Color.Red;
                textbox.ForeColor = Color.White;
            }
        }

        private void m_btn_One_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "1";
        }

        private void m_btn_two_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "2";
        }

        private void m_btn_three_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "3";
        }

        private void m_btn_four_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "4";
        }

        private void m_btn_five_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "5";
        }

        private void m_btn_six_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "6";
        }

        private void m_btn_seven_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "7";
        }

        private void m_btn_eight_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "8";
        }

        private void m_btn_nine_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "9";
        }

        private void m_btn_zero_Click(object sender, EventArgs e)
        {
            m_txt_Value.Text += "0";
        }

        private void m_txt_Value_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    m_btn_equal_Click(null, null);
                    return;
            }
        }
    }

}
