using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Piso : Inmueble //hereda de la clase abstracta inmueble
    {
        private int numPiso;
        private float precio;

        public Piso(int numPiso, string dir, int mCuad, int antig, float prec) : base(dir, mCuad, antig) //base indica los atributos heredados de la clase superior
        {
            this.direccion = dir;
            this.mCuadrados = mCuad;
            this.antiguedad = antig;
            this.numPiso = numPiso;
            this.precio = prec;
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
            if (this.numPiso >= 3)
            {
                valorFinal = valorFinal + (3 * valorFinal / 100);
            }
            return valorFinal;
        }
    }
}
