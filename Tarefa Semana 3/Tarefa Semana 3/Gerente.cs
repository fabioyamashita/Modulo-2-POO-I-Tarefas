using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_3
{
    public class Gerente : Funcionario
    {
        public const decimal BONIFICACAO_GERENTE = 0.25M;
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Gerente() { }
        public Gerente(string nome, decimal salario, string usuario, string senha) : base (nome, salario)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public override void MostraDados()
        {
            base.MostraDados();
            Console.WriteLine($"Usuário: {Usuario}");
            Console.WriteLine($"Senha: {Senha}");
        }

        public override void CalculaBonificacao()
        {
            Bonificacao = Salario * BONIFICACAO_GERENTE;
        }
    }
}
