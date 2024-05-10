using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System;
using System.Collections;
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
            Console.WriteLine("Visualizando Multas");

            Console.WriteLine();

            Console.WriteLine(
             "{0, -10} | {1, -15} | {2, -20} | {3, -20} | {4, -20}",
             "Id", "Tempo decorrido", "Valor", "Revista", "Amigo"
         );

            ArrayList multasCadastradas = repositorio.PegaRegistros();

            foreach (Multa multas in multasCadastradas)
            {
                Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20} | {5, -15}",
                multas.id, multas.TempoDecorrido, multas.Valor,
                multas.Revista, multas.Amigo
            );
            }

            Console.ReadLine();
            Console.WriteLine();
        }


        protected EntidadeBase GeraMulta(int tempoDecorrido, int valor, Revista revista, Amigo amigo)
        {
            return new Multa(tempoDecorrido, valor, revista, amigo);
        }

        public override char ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"        Gestão de {tipoEntidade}s        ");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine($"1 - Visualizar Multas");
            Console.WriteLine($"2 - Pagar Multas");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;

        }

        protected override EntidadeBase ObterRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
