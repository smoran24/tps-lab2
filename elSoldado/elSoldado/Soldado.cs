using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elSoldado
{
    class Soldado
    {
        private Arma _arma; //establece una relación de Asociación con la clase Arma al declarar un objeto de la otra clase

        public Soldado() //constructor vacío usado para crear el objeto Soldado por primera vez
        {
            
        }
        public Soldado(Arma arma) 
        {
            this._arma = arma;
        }
        public void RecogerArma(Arma p_arma)
        {
            if (this._arma != null)
            {
                Console.WriteLine("El soldado no puede usar dos armas a la vez. Por favor, deje el arma actual para tomar una nueva.");
            }
            else
            {
                this._arma = p_arma;
                Console.WriteLine("¡Ha recogido una nueva arma!");
            }
        }
        public void DejarArma()
        {
            if (this._arma != null)
            {
                this._arma = null;
                Console.WriteLine("Ha dejado el arma que tenía en sus manos");
            }
            else
            {
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
            }
        }
        public void JalarGatillo()
        {
            if (this._arma != null)
            {
                string sonidoDisparo = this._arma.Disparar();
                Console.WriteLine(sonidoDisparo);
            }
            else
            {
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
            }
        }
        public void VerArma()
        {
            if (this._arma != null)
            {
                Console.WriteLine(this._arma.getNombre());
            }
            else
            {
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
            }
        }
    }

}
