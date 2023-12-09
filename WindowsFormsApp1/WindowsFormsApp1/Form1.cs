using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
        //funcion para contar palabras:
        int numeroPalabras(string texto)
        {
            int palabras = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ' || texto[i] == '.')
                {
                    palabras++;
                }
            }
            return palabras;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (radioButton_urgente.Checked)
                tipoTelegrama = 'u';
            else if (radioButton_ordinario.Checked)
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = numeroPalabras(textoTelegrama);
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * (numPalabras - 10);
            }
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
