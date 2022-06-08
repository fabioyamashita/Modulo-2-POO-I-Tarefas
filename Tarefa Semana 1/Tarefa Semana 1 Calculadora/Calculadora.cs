using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_1_Calculadora
{
    class Calculadora
    {
        public double soma(double a, double b)
        {
            return a + b;
        }

        public double subtracao(double a, double b)
        {
            return a - b;
        }

        public double multiplicacao(double a, double b)
        {
            return a * b;
        }

        public double divisao(double a, double b)
        {
            return a / b;
        }

        public int potencia(int x, int y)
        {
            return (int)Math.Pow(x,y);
        }
    }
}
