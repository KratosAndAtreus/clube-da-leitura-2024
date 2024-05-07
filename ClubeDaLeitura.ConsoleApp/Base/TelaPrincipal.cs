using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Base
{
    internal class TelaPrincipal
    {
        public static char ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|           Clube da Leitura           |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Cadastro de Amigos");
            Console.WriteLine("2 - Cadastro de Caixas");
            Console.WriteLine("3 - Cadastro de Emprestimos");
            Console.WriteLine("4 - Cadastro de Reservas");
            Console.WriteLine("5 - Cadastro de Revistas");

            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");

            char opcaoEscolhida = Console.ReadLine()[0];

            return opcaoEscolhida;
        }
    }
}
