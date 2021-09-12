using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elSoldado
{
    class Revolver : Arma
    {
        public Revolver(string nombre) : base(nombre)//el constructor sobreescribe el parámetro nombre recibido de Arma
        {
            nombre = "Revolver - Colt .387";
        }

        public override string Disparar()//usa override para sobreescribir al método Disparar() de la super clase Arma
        {
            return "¡Púm!";
        }

    }
}
