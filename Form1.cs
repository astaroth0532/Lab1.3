using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var N = textBox1.Text;
            var x = new Double();
            var key = new Double();
            var bol = new Boolean();
            x = Convert.ToInt32(N);
            key = Math.Sqrt(x);
            key = Math.Abs(key);
            var Result = key * key;
            if (Result == x){
                bol = true;
            }
            else
            {
                bol = false;
            }
            label3.Text = Convert.ToString(bol);
        }
    }
}
