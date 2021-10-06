using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    abstract class Inmueble
    {
        protected string direccion;
        protected int mCuadrados;
        protected int antiguedad;

        public Inmueble(string dir, int mCuad, int antig)
        {
            this.direccion = dir;
            this.mCuadrados = mCuad;
            this.antiguedad = antig;
        }

    }
}
