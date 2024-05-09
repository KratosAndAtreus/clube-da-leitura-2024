using ClubeDaLeitura.ConsoleApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo.Multa
{
    internal class TelaMulta : TelaBase
    {
        public override void VisualizarRegistros(bool verTudo)
        {
            throw new NotImplementedException();
        }

        protected override EntidadeBase ObterRegistro()
        {
            throw new NotImplementedException();
        }

        public override char ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"        Gestão de {tipoEntidade}s        ");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine($"1 - visualizar Multas");
            Console.WriteLine($"2 - Pagar Multas");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;
        
        }
    }
}
