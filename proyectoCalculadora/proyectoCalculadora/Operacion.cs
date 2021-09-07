using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCalculadora
{
    class Operacion
    {
        private int num1, num2;

        public Operacion(int p_num1, int p_num2)
        {
            this.num1 = p_num1;
            this.num2 = p_num2;
        }
        public static int sumar(int p_num1, int p_num2)
        {
            int resultado;
            resultado = p_num1 + p_num2;
            return resultado;
        }
        public static int restar(int p_num1, int p_num2)
        {
            int resultado;
            resultado = p_num1 - p_num2;
            return resultado;
        }
    }
}
