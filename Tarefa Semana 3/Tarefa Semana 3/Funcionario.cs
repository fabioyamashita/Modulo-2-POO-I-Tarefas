using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_3
{
    public class Funcionario
    {
        public const decimal BONIFICACAO_FUNC = 0.1M;
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public decimal Bonificacao { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public virtual void MostraDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Salário: R$ {Salario.ToString("N2")}");
            Console.WriteLine($"Bonificação: R$ {Bonificacao.ToString("N2")}");
        }

        public virtual void CalculaBonificacao()
        {
            Bonificacao = Salario * BONIFICACAO_FUNC;
        }
    }
}
