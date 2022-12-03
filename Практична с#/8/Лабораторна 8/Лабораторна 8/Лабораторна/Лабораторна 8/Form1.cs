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
    public partial class Form1 : Form
    {       
        public int rectheight;
        public int rectwidth;
        public Color rectcolor = Color.Red;
        public bool check1 = true;
        public bool check2 = false;
        public bool check3 = false;
        public bool paint = false;
        public Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size_form f = new size_form();
            f.Owner = this;
            f.ShowDialog();
            нарисоватьToolStripMenuItem.Enabled = paint;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color_form f2 = new color_form();
            f2.Owner = this;
            f2.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((rectwidth == 0) || (rectheight == 0)) нарисоватьToolStripMenuItem.Enabled = false;
            else нарисоватьToolStripMenuItem.Enabled = true;

        }

        private void нарисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((rectwidth) >= this.Width - 17) MessageBox.Show("Прямоугольник превышает размеры окна");
            else if ((rectheight) >= this.Height - menuStrip1.Height - 47) MessageBox.Show("Прямоугольник превышает размеры окна");
            else
            {               
                g = this.CreateGraphics();
                g.Clear(Color.Transparent);
                g.DrawRectangle(new Pen(rectcolor, 2), 10, menuStrip1.Height + 10, rectwidth, rectheight);
            }
        }
    }
}
