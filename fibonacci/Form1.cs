using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i, f0 = 1, f1 = 1, f2 = 1;
            n = int.Parse(textBox1.Text);
            for (i = 2; i <= n;i++ )
            {
                f2 = f1 + f0;
                f0 = f1;
                f1 = f2;
            }
            textBox2.Text += "\r\n cel de al " + n.ToString() + " termen fibonacci este " + f2.ToString() + "\r\n";
        }
    }
}
