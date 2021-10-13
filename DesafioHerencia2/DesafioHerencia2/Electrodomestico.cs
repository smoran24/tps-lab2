using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia2
{
    class Electrodomestico
    {
        protected int precioBase = 100;
        protected string color = "blanco";
        protected char consumo = 'F';
        protected int peso = 5;

        public Electrodomestico()
        {
        }
        public Electrodomestico(int precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
        public Electrodomestico(int precioBase, string color, char consumo, int peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumo = consumo;
            this.peso = peso;
            comprobarConsumoEnergetico(consumo);
            comprobarColor(color);

        }
        public int getPrecioBase()
        {
            return this.precioBase;
        }
        public string getColor()
        {
            return this.color;
        }
        public char getConsumo()
        {
            return this.consumo;
        }
        public int getPeso()
        {
            return this.peso;
        }
        public void comprobarConsumoEnergetico(char letra)
        {
            if (letra!='A' || letra!='B' || letra!='C' || letra!='D' || letra != 'E' || letra != 'F')
            {
                this.consumo = 'F';
            }
        }
        public void comprobarColor(string p_color)
        {
            if (p_color != "blanco" || p_color != "negro" || p_color != "rojo" || p_color != "azul" || p_color != "gris") 
            {
                this.color = "blanco";
            }
        }
        public void precioFinal()
        {
            switch (this.consumo)
            {
                case 'A':
                    this.precioBase = this.precioBase + 100;
                    break;
                case 'B':
                    this.precioBase = this.precioBase + 80;
                    break;
                case 'C':
                    this.precioBase = this.precioBase + 60;
                    break;
                case 'D':
                    this.precioBase = this.precioBase + 50;
                    break;
                case 'E':
                    this.precioBase = this.precioBase + 30;
                    break;
                case 'F':
                    this.precioBase = this.precioBase + 10;
                    break;
            }
            if (this.peso > 0 && this.peso <= 19)
            {
                this.precioBase = this.precioBase + 10;
            }else if (this.peso >= 20 && this.peso <= 49)
            {
                this.precioBase = this.precioBase + 50;
            }else if (this.peso >= 50 && this.peso <= 79)
            {
                this.precioBase = this.precioBase + 80;
            }
            else
            {
                this.precioBase = this.precioBase + 100;
            }
        }
    }
}
