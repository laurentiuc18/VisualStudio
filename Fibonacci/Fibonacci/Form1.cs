using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int p = 0;
            int q = 1;
            int numero = int.Parse(textBox1.Text);

            for (int i = 0; i <numero;  i++)
	{
	    int temp = p;
	    p = q;
	    q = temp + q;

                label1.Text = label1.Text + p + " ";
            }
           
        }
    }
}
