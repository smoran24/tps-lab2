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
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Pasar(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/sebia/Pictures/2d4fd9b2-025b-4227-b23d-aea7e966525e.jpeg";
        }

        private void Irse(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/sebia/Pictures/D8F1L8sW4AErQ2S.jpeg";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (chkMonitor.Checked == true)
            {
                total = total + 250;
            }
            if (chkTeclado.Checked == true)
            {
                total = total + 15;
            }
            if (chkMouse.Checked == true)
            {
                total = total + 20;
            }
            MessageBox.Show("El total es " + total.ToString());
        }

        private void chkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonitor.Checked == true)
            {
                label1.Text = "Monitor";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = "Hombre";
            }
            else
            {
                label2.Text = "Mujer";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            int n = dgvProductos.Rows.Add(); //rows es renglón
            dgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text; //añado el contenido del text box codigo
            dgvProductos.Rows[n].Cells[1].Value = txtNombre.Text; //añado el contenido del text box nombre
            dgvProductos.Rows[n].Cells[2].Value = txtPrecio.Text; //añado el contenido del text box precio

            txtCodigo.Text = ""; //limpiamos los textbox
            txtNombre.Text = "";
            txtPrecio.Text = "";

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e) //evento al cliquear sobre una celda
        {
            int n = e.RowIndex; //rowindex es el indice de la fila
            if (n != -1)
            {
                labelInfo.Text = (string)dgvProductos.Rows[n].Cells[1].Value; //convierto a string el valor en esa posición para mostrarla en el label
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dgvProductos.Rows.RemoveAt(n); //borra el renglon entero en N seleccionado
            }
        }
    }
}
