using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush brush = Brushes.White;
            Graphics gr = this.CreateGraphics();
            gr.FillPie(brush, 0, 0, 100, 100, -90, 90);
            gr.Dispose();


        }
    }
}
