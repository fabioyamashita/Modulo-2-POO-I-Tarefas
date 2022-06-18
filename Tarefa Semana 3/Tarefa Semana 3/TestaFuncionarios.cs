using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Semana_3
{
    public class TestaFuncionarios
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Fabio Yamashita", 15000.0M, "fyama", "FRC12F?*");
            gerente.CalculaBonificacao();
            gerente.MostraDados();
            Console.WriteLine();

            Telefonista telefonista = new Telefonista("Eduardo Telefonista", 5000.0M, "2F-43");
            telefonista.CalculaBonificacao();
            telefonista.MostraDados();
            Console.WriteLine();

            Secretaria secretaria = new Secretaria("Maria Secretária", 4000.0M, 15215151);
            secretaria.CalculaBonificacao();
            secretaria.MostraDados();
            Console.WriteLine();

        }
    }
}
