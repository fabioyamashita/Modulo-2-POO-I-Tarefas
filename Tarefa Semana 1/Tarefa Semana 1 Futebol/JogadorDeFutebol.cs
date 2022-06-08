using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_1_Futebol
{
    class JogadorDeFutebol
    {
        public string? nome;
        public string? posicao;
        public DateTime dataNascimento;
        public string? nacionalidade;
        public double altura;
        public double peso;

        public void imprimirDados()
        {
            Console.WriteLine("Dados do jogador: ");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Posição: {posicao.ToUpper()}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Nacionalidade: {nacionalidade}");
            Console.WriteLine($"Altura: {altura.ToString("N2")} m");
            Console.WriteLine($"Peso: {peso} kg");
        }

        public int calculaIdade()
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade = idade - 1;
            }

            return idade;
        }

        public void calculaTempoAposentadoria()
        {
            int anosParaAposentadoria = 0;
            int idadeAposentadoria = 0;

            switch (posicao.ToUpper())
            {
                case "DEFESA":
                    idadeAposentadoria = 40;
                    break;
                case "MEIO-CAMPO":
                    idadeAposentadoria = 38;
                    break;
                case "ATACANTE":
                    idadeAposentadoria = 35;
                    break;
            }

            // Calculando o tempo de forma simplificada
            anosParaAposentadoria = idadeAposentadoria - calculaIdade() - 1;

            Console.WriteLine("\n------- CÁLCULO SIMPLIFICADO -------");
            Console.WriteLine($"Faltam {anosParaAposentadoria} anos para se aposentar!");
            Console.WriteLine("------------------------------------");


            // Calculando de forma completa (Considerando 360 dias por ano)
            DateTime dataAposentadoria = new DateTime(dataNascimento.Year + idadeAposentadoria, dataNascimento.Month, dataNascimento.Day);
            long dataAposentadoria360Dias = dataAposentadoria.Year * 360 + dataAposentadoria.Month * 30 + dataAposentadoria.Day;
                    
            DateTime dataHoje = DateTime.Now;
            long dataHoje360Dias = dataHoje.Year * 360 + dataHoje.Month * 30 + dataHoje.Day;

            long difDatas360Dias = dataAposentadoria360Dias - dataHoje360Dias;

            int anosFaltantes = (int)difDatas360Dias / 360;
            int mesesFaltantes = (int)((difDatas360Dias % 360) / 30);
            int diasFaltantes = (int)((difDatas360Dias % 360) % 30);

            Console.WriteLine("\n--- CÁLCULO COMPLETO (Considerando 360 dias/ano) ---");
            Console.WriteLine($"Data de Hoje: {dataHoje.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Data da Aposentadoria: {dataAposentadoria.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Tempo faltante: {anosFaltantes} ano(s), {mesesFaltantes} mes(es) e {diasFaltantes} dia(s)");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
