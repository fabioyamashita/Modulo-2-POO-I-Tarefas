using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_2_Gerente
{
    class TestaMetodosGerente
    {
        static void Main(string[] args)
        {
            Gerente ger1 = new Gerente("Fabio Yamashita", 5000.0);

            ger1.ConsultaDados();
            ger1.ImprimirSalario();
            
            ger1.AumentaSalario();
            ger1.AumentaSalario(0.2);
            ger1.AplicaBonus(ger1.salario);

            ger1.ConsultaDados();
            ger1.ImprimirSalario();
            
        }
    }
}
