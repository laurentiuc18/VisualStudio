using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                respuesta.Text = "Porfavor ingrese un numero";
            }
            else { 

            Double numero = Convert.ToDouble(textBox1.Text);

            if (numero < 0) { respuesta.Text = "Ingrese un numero superior o igual a 0"; }
            if (numero > 10) { respuesta.Text = "Ingrese un numero inferior o igual a 10"; }

            if (numero >= 0 && numero <= 4.9) { respuesta.Text = "Suspendido"; }
            if (numero >= 5 && numero <= 6.9) { respuesta.Text = "Aprobado"; }
            if (numero >= 7 && numero <= 8.9) { respuesta.Text = "Notable"; }
            if (numero >= 9 && numero <= 10) { respuesta.Text = "Sobresaliente"; }

        }
            
        }
    }
}
