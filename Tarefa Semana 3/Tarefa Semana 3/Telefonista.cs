using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_3
{
    public class Telefonista : Funcionario
    {
        public string CodigoEstacaoTrabalho { get; set; }

        public Telefonista() { }
        public Telefonista(string nome, decimal salario, string codigoEstacaoTrabalho) : base(nome, salario)
        {
            CodigoEstacaoTrabalho = codigoEstacaoTrabalho;
        }
        public override void MostraDados()
        {
            base.MostraDados();
            Console.WriteLine($"Código da Estação de trabalho: {CodigoEstacaoTrabalho}");
        }
    }
}
