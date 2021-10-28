using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioWinForms_SebastianMoran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radCamisa.Checked == true)
            {
                chkBermuda.Hide(); //oculta el otro checkbox
                chkBermuda.Checked = false;
                chkMangaCorta.Show();//muestra el checkbox propio
            }
        }

        private void radPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (radPantalon.Checked == true)
            {
                chkMangaCorta.Hide(); //oculta el otro checkbox
                chkMangaCorta.Checked = false;
                chkBermuda.Show();//muestra el checkbox propio
            }
        }

        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (radStandard.Checked == true)
            {
                radPremium.Checked = false;
            }
        }

        private void radPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radPremium.Checked == true)
            {
                radStandard.Checked = false;
            }
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            float precioFinal;
            string calidad = "Standard";
            string tipoCamisa;
            string tipoPantalon;
            float precio = Convert.ToSingle(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            if (radPremium.Checked == true)
            {
                calidad = "Premium";
            }
            if (radCamisa.Checked == true)
            {
                if (chkMangaCorta.Checked == true)
                {
                    tipoCamisa = "Manga corta";

                }
                else
                {
                    tipoCamisa = "Manga larga";
                }
                Camisa miCamisa = new Camisa(tipoCamisa, calidad, precio, cantidad);
                precioFinal = miCamisa.calcularValor(); //polimorfismo aplicado a la función calcularValor de la clase Camisa
                MessageBox.Show("El precio final es de: " + precioFinal);
            }
            if (radPantalon.Checked == true)
            {
                if (chkBermuda.Checked == true)
                {
                    tipoPantalon = "Bermuda";
                }
                else
                {
                    tipoPantalon = "Largo";
                }
                Pantalon miPantalon = new Pantalon(tipoPantalon, calidad, precio, cantidad);
                precioFinal = miPantalon.calcularValor(); //polimorfismo aplicado a la función calcularValor de la clase Pantalon
                MessageBox.Show("El precio final es de: " + precioFinal);
            }
            
        }
    }
}
