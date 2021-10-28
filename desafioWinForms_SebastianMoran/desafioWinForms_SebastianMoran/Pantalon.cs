using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioWinForms_SebastianMoran
{
    class Pantalon : Prenda
    {
        private string tipo = "Largo";

        public Pantalon(string tipo, string calidad, float precio, int cantidad) : base(calidad, precio, cantidad)
        {
            this.calidad = calidad;
            this.precio = precio;
            this.cantidad = cantidad;
            this.tipo = tipo;
        }
        public override float calcularValor()
        {
            float valorFinal = base.calcularValor(); //se basa en el resultado de la función padre
            if (this.tipo == "Bermuda")
            {
                valorFinal = valorFinal - (20 * valorFinal / 100);
            }
            return valorFinal;
        }
    }
}
