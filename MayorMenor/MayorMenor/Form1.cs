using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Double numero1 = Convert.ToDouble(textBox1.Text);
            Double numero2 = Convert.ToDouble(textBox2.Text);

            if (numero1 > numero2)
            {
                respuesta.Text = numero1 + " es mayor que " + numero2;

            }
            else if (numero1 == numero2)
            {
                respuesta.Text =" Son iguales";
            }
            else { 
                respuesta.Text = numero2 + " es mayor que " + numero1; 
            }
        }
    }
}
