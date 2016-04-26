using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Treug tr = new Treug();
            label1.Text = "Периметр: " + Convert.ToString(tr.Perimetr());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kvadrat kv = new Kvadrat();
            label2.Text = "Периметр: " + Convert.ToString(kv.Perimetr());
        }
    }
}
