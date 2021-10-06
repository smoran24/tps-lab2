using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Local : Inmueble
    {
        private int numVentanas;
        private float precio;

        public Local(int numVentanas, string dir, int mCuad, int antig) : base(dir,  mCuad,  antig)
        {
            this.direccion = dir;
            this.mCuadrados = mCuad;
            this.antiguedad = antig;
            this.numVentanas = numVentanas;
            this.precio = 3900000.0f;
        }

        public float calcularValor()
        {
            float valorFinal;
            valorFinal = this.precio;
            if (this.antiguedad < 15)
            {
                valorFinal = valorFinal - (1 * valorFinal / 100);
            }
            else
            {
                valorFinal = valorFinal - (2 * valorFinal / 100);
            }
            if (this.mCuadrados > 50)
            {
                valorFinal = valorFinal + (1 * valorFinal / 100);
            }
            if (this.numVentanas == 1 || this.numVentanas == 0)
            {
                valorFinal = valorFinal - (2 * valorFinal / 100);
            }
            else if (this.numVentanas > 4)
            {
                valorFinal = valorFinal + (4 * valorFinal / 100);
            }
            return valorFinal;
        }
    }
}
