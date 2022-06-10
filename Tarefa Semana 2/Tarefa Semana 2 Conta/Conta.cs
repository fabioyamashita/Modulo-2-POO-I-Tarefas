using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_2_Conta
{
    public class Conta
    {
        public int numConta;
        public double saldoConta;
        public double limiteConta;
        public List<double> listaMovimentacoes;

        public Conta(int numConta)
        {
            this.numConta = numConta;
            this.listaMovimentacoes = new List<double>();
        }
        public Conta(int numConta, double saldoConta, double limiteConta) : this(numConta)
        {
            this.saldoConta = saldoConta;
            this.limiteConta = limiteConta;
        }

        public void Deposita(double valorDeposito)
        {
            saldoConta += valorDeposito;
            listaMovimentacoes.Add(valorDeposito);
        }
        public void Saca(double valorSaque)
        {
            if (valorSaque > saldoConta)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                saldoConta -= valorSaque;
                listaMovimentacoes.Add(-valorSaque);
            }
        }
        public void ImprimirExtrato()
        {
            // De padrão, imprimir todas as movimentações
            this.ImprimirExtrato(listaMovimentacoes.Count);
        }
        public void ImprimirExtrato(int numMovimentacoes)
        {
            // Imprimindo as últimas n movimentações

            if(numMovimentacoes > listaMovimentacoes.Count)
            {
                Console.WriteLine($"\nVocê não possui {numMovimentacoes} movimentações na conta!");
                Console.WriteLine($"Vamos mostrar para você todas as {listaMovimentacoes.Count} movimentações da sua conta!");
                numMovimentacoes = listaMovimentacoes.Count;
            }

            Console.WriteLine($"\n### SEU EXTRATO DAS ÚLTIMAS {numMovimentacoes} MOVIMENTAÇÕES ###");
            for (int i = listaMovimentacoes.Count - 1; i >= 0; i--)
            {
                if(listaMovimentacoes[i] > 0)
                {
                    Console.WriteLine($"#{i+1} Depósito: +R$ {listaMovimentacoes[i].ToString("N2")}");
                }
                else
                {
                    Console.WriteLine($"#{i+1} Saque: -R$ {Math.Abs(listaMovimentacoes[i]).ToString("N2")}");
                }
            }
            Console.WriteLine($"-----------------------------------------------");
        }
        public void ConsultaSaldo()
        {
            Console.WriteLine("\n### CONSULTA SALDO ###");
            Console.WriteLine($"Conta: {numConta}");
            Console.WriteLine($"Saldo: R$ {saldoConta.ToString("N2")}");
            Console.WriteLine("------------------------");
        }
    }
}
