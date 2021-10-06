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
            txtNumVentanas.Clear(); //borra el texto de tal casilla
            txtNumPiso.Show();//muestra la casilla de texto propia
        }
        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            txtNumPiso.Hide();//oculta la otra casilla de texto
            txtNumPiso.Clear();//borra el texto de tal casilla
            txtNumVentanas.Show();//muestra la casilla de texto propia
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            float valorFinal;
            int antiguedad = Convert.ToInt32(txtAntiguedad.Text); //convierte a int el string de la textbox antiguedad
            int mCuadrados = Convert.ToInt32(txtSuperficie.Text);
            float prec = Convert.ToSingle(txtPrecioBase.Text); //convierte a float (single) el string de la textbox preciobase
            string dir = txtDireccion.Text;

            if (rbLocal.Checked == true)
            {
                int numVentanas = Convert.ToInt32(txtNumVentanas.Text);
                Local miLocal = new Local(numVentanas, dir, mCuadrados, antiguedad, prec);
                valorFinal = miLocal.calcularValor(); //polimorfismo aplicado a la función calcularValor de la clase Local
                labelResultado.Text = "El precio final del local es: $" + valorFinal.ToString();
            }
            if (rbPiso.Checked == true)
            {
                int numPiso = Convert.ToInt32(txtNumPiso.Text);
                Piso miPiso = new Piso(numPiso, dir, mCuadrados, antiguedad, prec);
                valorFinal = miPiso.calcularValor(); //polimorfismo aplicado a la función calcularValor de la clase Piso
                labelResultado.Text = "El precio final del piso es: $" + valorFinal.ToString();
            }
            
        }
    }
}
