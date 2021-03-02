using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarPalabras
{
    public partial class Form1 : Form
    {
		
        ArrayList lista = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Guardar(object sender, EventArgs e)
        {
			
			
			

			
                lista.Add(textBox1.Text);

                textBox1.Text = "";
                textBox1.Focus();





        }

        private void Stop_Click(object sender, EventArgs e)
        {
			
            lista.Sort();
            label2.Text = string.Join("\n", lista.Cast<string>());
        }
    
    }
}
