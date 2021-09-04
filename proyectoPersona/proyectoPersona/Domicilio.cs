using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPersona
{
    class Domicilio
    {
        private String calle;
        private int numero;

        public Domicilio()
        {
        }
        public Domicilio(string calle, int numero)
        {
            this.calle = calle;
            this.numero = numero;
        }
        public String getCalle()
        {
            return this.calle;
        }
        public int getNumero()
        {
            return this.numero;
        }
        public void setCalle(String calle)
        {
            this.calle=calle;
        }
        public void setNumero(int num)
        {
            this.numero = num;
        }

    }
}
