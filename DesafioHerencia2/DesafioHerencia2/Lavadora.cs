using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia2
{
    class Lavadora : Electrodomestico
    {
        private int carga = 5;

        public Lavadora()
        {
        }

        public Lavadora(int precioBase, int peso) : base(precioBase, peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
        public Lavadora(int carga,  int precioBase, int peso) : base(precioBase, peso)
        {
            this.carga = carga;
            this.precioBase = precioBase;
            this.peso = peso;
        }
        public int getCarga()
        {
            return this.carga;
        }
        public void precioFinal()
        {
            //Console.WriteLine("CALCULANDO PRECIOFINAL EN LAVADORA.CS");
            if (this.carga > 30)
                this.precioBase = this.precioBase + 50;
        }
    }
}
