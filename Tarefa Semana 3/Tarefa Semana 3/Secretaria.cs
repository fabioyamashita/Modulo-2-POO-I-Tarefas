using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_3
{
    public class Secretaria : Funcionario
    {
        public long NumeroRamal { get; set; }

        public Secretaria(string nome, decimal salario, long numeroRamal) : base(nome, salario)
        {
            NumeroRamal = numeroRamal;
        }
        public override void MostraDados()
        {
            base.MostraDados();
            Console.WriteLine($"Número do Ramal: {NumeroRamal}");
        }
    }
}
