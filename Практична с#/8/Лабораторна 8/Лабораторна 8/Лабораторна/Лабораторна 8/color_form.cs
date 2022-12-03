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
    public partial class color_form : Form
    {
        public color_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.check1 = radioButton1.Checked;
            main.check2 = radioButton2.Checked;
            main.check3 = radioButton3.Checked;
            if (radioButton1.Checked == true) main.rectcolor = Color.Red;
            else if (radioButton2.Checked == true) main.rectcolor = Color.Green;
            else if (radioButton3.Checked == true) main.rectcolor = Color.Blue;
            this.Hide();
            
        }

        private void color_form_Load(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main.check1 == true) radioButton1.Checked = true;
            else if (main.check2 == true) radioButton2.Checked = true;
            else if (main.check3 == true) radioButton3.Checked = true;
        }

        private void color_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main.check1 == true) radioButton1.Checked = true;
            else if (main.check2 == true) radioButton2.Checked = true;
            else if (main.check3 == true) radioButton3.Checked = true;
        }


    }
}
