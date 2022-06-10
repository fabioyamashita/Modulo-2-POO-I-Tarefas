using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_2_Conta
{
    public class TestaMetodosConta
    {
        static void Main(string[] args)
        {
            // Criando diferentes contas com diferentes construtores
            Conta c1 = new Conta(15065, 0, 1500);
            Conta c2 = new Conta(10500);

            // Testando com a conta c1
            c1.Deposita(150);
            c1.Deposita(1000);
            c1.Saca(100);
            c1.Saca(500);
            c1.Saca(500);
            c1.Deposita(500);
            c1.Deposita(50);
            c1.Deposita(10);

            c1.ConsultaSaldo();

            c1.ImprimirExtrato(10);

            // Testando com a conta c2
            c2.Deposita(150);
            c2.Deposita(1000);
            c2.Saca(1000);

            c2.ConsultaSaldo();

            c2.ImprimirExtrato();
        }
    }
}
