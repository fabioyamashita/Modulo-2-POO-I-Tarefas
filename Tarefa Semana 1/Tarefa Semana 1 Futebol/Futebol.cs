using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_1_Futebol
{
    class Futebol
    {
        public static void Main(string[] args)
        {
            JogadorDeFutebol jogador1 = new JogadorDeFutebol();

            jogador1.nome = "Fabio Yamashita";
            jogador1.posicao = "defesa";
            jogador1.dataNascimento = new DateTime(2000, 3, 1);
            jogador1.nacionalidade = "Brasileiro";
            jogador1.altura = 1.70;
            jogador1.peso = 68;

            jogador1.imprimirDados();

            Console.WriteLine($"\nIdade: {jogador1.calculaIdade()} anos");

            jogador1.calculaTempoAposentadoria();

        }
    }
}
