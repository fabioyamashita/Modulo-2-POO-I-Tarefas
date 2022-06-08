using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_1_Calculadora
{
    class TestaCalculadora
    {
        public static void Main(string[] args)
        {
            try
            {
                Calculadora calculadora = new Calculadora();

                double a = 15.0;
                double b = 5;

                int intA = 3;
                int intB = 3;

                Console.WriteLine("Calculadora: ");
                Console.WriteLine($"{a} + {b} = {calculadora.soma(a,b)}");
                Console.WriteLine($"{a} - {b} = {calculadora.subtracao(a,b)}");
                Console.WriteLine($"{a} * {b} = {calculadora.multiplicacao(a,b)}");
                Console.WriteLine($"{a} / {b} = {calculadora.divisao(a,b)}");
                Console.WriteLine($"{intA} ^ {intB} = {calculadora.potencia(intA, intB)}");

            }
            catch (DivideByZeroException)
            {
                // Exceção de zero só vai disparar se estivermos tratando de int ou decimal
                Console.WriteLine("Impossível calcular! Divisão por zero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Operação inválida!");
            }
        }
    }
}
