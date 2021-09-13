using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeCompras_MoranSebastian
{
    class Camisa
    {
        private double precioUnitario;

        public Camisa()
        {
            this.precioUnitario = 1000;
        }
        public double getPrecioUnitario()
        {
            return this.precioUnitario;
        }
        public void sumarPrecioUnitario()
        {
            this.precioUnitario = this.precioUnitario + 1000;
        }
        public void restarPrecioUnitario()
        {
            this.precioUnitario = this.precioUnitario - 1000;
        }
    }
}
