using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_1_Semana_1_RegistroAcademico
{
    class RegistroAcademico
    {
        public string? nome;
        public int matricula;
        public DateTime dataNascimento;
        public bool eBolsista;
        public int anoMatricula;
        public double mensalidade = 650.0;

        public double calculaMensalidade()
        {
            if (eBolsista)
                mensalidade = 0.5 * mensalidade;

            return mensalidade;
        }

        public void mostrarRegistro()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Ano Matrícula: {anoMatricula}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento.ToString("dd/MM/yyyy")}");
            Console.WriteLine("É Bolsista?: " + (eBolsista ? "Sim" : "Não"));
            Console.WriteLine($"Mensalidade: R$ {calculaMensalidade().ToString("N2")}");
        }
    }
}
