using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elSoldado
{
    abstract class Arma //es abstracta la clase porque no se puede instanciar
    {
        protected string _nombre; //es protected para que sea heredado

        public Arma(string nombre)
        {
            _nombre = nombre;
        }
        public abstract string Disparar(); //sirve para poder utilizar la función abstracta Disparar() de las 3 subclases

        public string getNombre()
        {
            return _nombre;
        }
    }

}
