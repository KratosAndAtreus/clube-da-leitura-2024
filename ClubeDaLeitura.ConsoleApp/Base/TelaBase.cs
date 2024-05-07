using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Base
{
    internal class TelaBase
    {
        public string tipoEntidade = "";
        public RepositorioBase repositorio = null;

        public char ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"        Gestão de {tipoEntidade}s        ");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine($"1 - Cadastrar {tipoEntidade}");
            Console.WriteLine($"2 - Editar {tipoEntidade}");
            Console.WriteLine($"3 - Excluir {tipoEntidade}");
            Console.WriteLine($"4 - Visualizar {tipoEntidade}s");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;
        }
    }
}
