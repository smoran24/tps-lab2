using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia2
{
    class Television : Electrodomestico
    {
        private int resolucion = 20;
        private bool sintonizador = false;
        public Television()
        {
        }
        public Television(int precioBase, int peso) : base  (precioBase, peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
        public Television(int resolucion, bool sintonizador, int precioBase, int peso) : base(precioBase, peso)
        {
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
            this.precioBase = precioBase;
            this.peso = peso;
        }
        public int getResolucion()
        {
            return this.resolucion;
        }
        public bool getSintonizador()
        {
            return this.sintonizador;
        }
        public void precioFinal()
        {
            //Console.WriteLine("CALCULANDO PRECIOFINAL EN TELEVISION.CS");
            if(this.resolucion > 40)
            {
                this.precioBase = this.precioBase + (30 * this.precioBase / 100);
            }
            if(this.sintonizador == true)
            {
                this.precioBase = this.precioBase + (50 * this.precioBase / 100);
            }
        }
    }
}
