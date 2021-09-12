using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elSoldado
{
    class Rifle : Arma
    {
        public Rifle(string nombre) : base(nombre) //el constructor sobreescribe el parámetro nombre recibido de Arma
        {
            nombre = "Rifle - Colt M4A1";
        }

        public override string Disparar() //usa override para sobreescribir al método Disparar() de la super clase Arma
        {
            return "¡Pám, pám, pám!";
        }
    }
    
}
