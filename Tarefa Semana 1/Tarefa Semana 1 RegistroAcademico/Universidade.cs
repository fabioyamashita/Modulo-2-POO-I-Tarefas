using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_1_Semana_1_RegistroAcademico
{
    class TestaUniversidade
    {
        public static void Main(string[] args)
        { 
            RegistroAcademico reg1 = new RegistroAcademico();

            reg1.nome = "Fabio Yamashita";
            reg1.matricula = 150500;
            reg1.dataNascimento = new DateTime(1992, 1, 6);
            reg1.eBolsista = true;
            reg1.anoMatricula = 2022;
            reg1.mensalidade = 650.0;

            reg1.mostrarRegistro();
        }
    }
}
