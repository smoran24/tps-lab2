using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_SebastianMoran
{
    abstract class Prenda
    {
        protected string calidad;
        protected float precio;
        protected int cantidad;

        protected Prenda(string calidad, float precio, int cantidad)
        {
            this.calidad = calidad;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public virtual float calcularValor() //es virtual porque la función va a heredarse a las clases hijas
        {
            float valorFinal;
            valorFinal = this.precio * this.cantidad;
            if (this.calidad == "Premium")
            {
                valorFinal = valorFinal + (30 * valorFinal / 100);
            }
            return valorFinal;
        }
    }
}
