using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MafiaHelp
{
    public partial class size_form : Form
    {        
        public size_form()
        {          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.rectwidth = Convert.ToInt32(textBox1.Text);
            main.rectheight = Convert.ToInt32(textBox2.Text);
            if ((main.rectwidth == 0) || (main.rectheight == 0)) main.paint = false;
            else main.paint = true;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") textBox2.Text = "0";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void size_form_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            textBox1.Text = Convert.ToString(main.rectwidth);
            textBox2.Text = Convert.ToString(main.rectheight);
        }
    }
}
