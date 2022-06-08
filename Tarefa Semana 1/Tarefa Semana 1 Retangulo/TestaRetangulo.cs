using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_1_Retangulo
{
    class TestaRetangulo
    {
        public static void Main(string[] args)
        {
            const int NUM_RETANGULOS = 10;

            Retangulo[] arrRetangulos = new Retangulo[NUM_RETANGULOS];

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"Vamos ler os dados de {NUM_RETANGULOS} retângulos e vamos mostrar pra você!");
            Console.WriteLine("--------------------------------------------------------------");

            for (int i = 0; i < NUM_RETANGULOS; i++)
            {
                arrRetangulos[i] = new Retangulo();

                // Validando a altura
                bool alturaValida = false;
                while (!alturaValida)
                {
                    Console.Write($"\nDigite a altura do {i + 1}º retângulo: ");
                    string? alturaDigitada = Console.ReadLine();

                    alturaValida = double.TryParse(alturaDigitada, out arrRetangulos[i].altura) && arrRetangulos[i].altura > 0;

                    if (alturaValida)
                        break;

                    Console.WriteLine("\nDigite uma altura válida!");
                }

                // Validando a largura
                bool larguraValida = false;
                while (!larguraValida)
                {
                    Console.Write($"Digite a largura do {i + 1}º retângulo: ");
                    string? larguraDigitada = Console.ReadLine();

                    larguraValida = double.TryParse(larguraDigitada, out arrRetangulos[i].largura) && arrRetangulos[i].largura > 0;

                    if (larguraValida)
                        break;

                    Console.WriteLine("\nDigite uma largura válida!");
                }

                Console.Clear();
            }

            for (int i = 0; i < NUM_RETANGULOS; i++)
            {
                Console.WriteLine($"Dados do {i + 1}º retângulo:");
                arrRetangulos[i].mostrarAlturaLargura();
                Console.WriteLine("-------------------------------");
            }
        }
    }
}