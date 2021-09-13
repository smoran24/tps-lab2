using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_MoranSebastian
{
    class Carrito
    {
        private int cantCamisas = 0;
        private double precioFinalSinDesc = 0;
        private int descuento = 0;
        private double precioFinal = 0;
        private Camisa cam = new Camisa(); //crea un objeto de tipo camisa para poder interactuar con la clase camisa

        public Carrito() //constructor vacío, no necesita recibir parametros ni inicializar atributos
        {
        }

        public int getCantCamisas()
        {
            return this.cantCamisas;
        }
        public double getPrecioFinalSinDesc()
        {
            return this.precioFinalSinDesc;
        }
        public int getDescuento()
        {
            return this.descuento;
        }
        public double getPrecioFinal()
        {
            return this.precioFinal;
        }
        public void calcularPrecioTotalSinDesc()
        {
            this.precioFinalSinDesc = this.cantCamisas * 1000;
        }
        public void calcularDescuento()
        {
            if (this.cantCamisas >= 3 && this.cantCamisas <= 5)
            {
                this.descuento = 10;
            }else if (this.cantCamisas > 5)
            {
                this.descuento = 20;
            }
            else
            {
                this.descuento = 0; //resetea el descuento si no se cumplen las condiciones anteriores
            }
                
        }
        public void calcularPrecioTotal()
        {
            double porcentajeDescuento;
            porcentajeDescuento = this.descuento * this.precioFinalSinDesc / 100;
            this.precioFinal = this.precioFinalSinDesc - porcentajeDescuento;
        }
        public void addCamisa()
        {
            this.cantCamisas = this.cantCamisas + 1;
            cam.sumarPrecioUnitario();
            calcularPrecioTotalSinDesc();
            calcularDescuento();
            calcularPrecioTotal();
        }
        public void deleteCamisa()
        {
            if (this.cantCamisas == 0)
            {
                Console.WriteLine("Error: no hay camisas en el carrito.");
            }
            else
            {
                this.cantCamisas = this.cantCamisas - 1;
                cam.restarPrecioUnitario();
                calcularPrecioTotalSinDesc();
                calcularDescuento();
                calcularPrecioTotal();
            }
        }
    }
}
