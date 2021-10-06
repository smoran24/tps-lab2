using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbPiso_CheckedChanged(object sender, EventArgs e)
        {
            txtNumVentanas.Hide(); //oculta la otra casilla de texto
            txtNumVentanas.Clear(); //borra el texto de la casilla
            txtNumPiso.Show();
        }
        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            txtNumPiso.Hide();//oculta la otra casilla de texto
            txtNumPiso.Clear();//borra el texto de la casilla
            txtNumVentanas.Show();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            String seleccion = "";
            float valorFinal = 0;
            valorFinal = Convert.ToSingle(txtPrecioBase.Text);//convierte a float (single) el string de la textbox preciobase
            int antiguedad = Convert.ToInt32(txtAntiguedad.Text); //lo mismo pero a int con el string del txtbox antiguead
            int mCuadrados = Convert.ToInt32(txtSuperficie.Text);

            if (rbLocal.Checked == true)
            {
                seleccion = "local";
                int numVentanas = Convert.ToInt32(txtNumVentanas.Text);
                if (antiguedad < 15)
                {
                    valorFinal = valorFinal - (1 * valorFinal / 100);
                }
                else
                {
                    valorFinal = valorFinal - (2 * valorFinal / 100);
                }
                if (mCuadrados > 50)
                {
                    valorFinal = valorFinal + (1 * valorFinal / 100);
                }
                if (numVentanas == 1 || numVentanas == 0)
                {
                    valorFinal = valorFinal - (2 * valorFinal / 100);
                }
                else if (numVentanas > 4)
                {
                    valorFinal = valorFinal + (4 * valorFinal / 100);
                }
            }
            if (rbPiso.Checked == true)
            {
                seleccion = "piso";
                int numPiso = Convert.ToInt32(txtNumPiso.Text);
                if (antiguedad < 15)
                {
                    valorFinal = valorFinal - (1 * valorFinal / 100);
                }
                else
                {
                    valorFinal = valorFinal - (2 * valorFinal / 100);
                }
                if (numPiso >= 3)
                {
                    valorFinal = valorFinal + (3 * valorFinal / 100);
                }
            }
            labelResultado.Text = "El precio final del " + seleccion + " es: $" + valorFinal.ToString();
        }
    }
}
