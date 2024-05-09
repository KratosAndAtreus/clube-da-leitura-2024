using System.Collections;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Reserva;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    internal class TelaRevista : TelaBase
    {
        public TelaCaixa telaCaixa = null;

        public RepositorioCaixa repositorioCaixa = null;

        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Por favor, informe o TITULO da revista");
            string titulo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor, informe o NUMERO DA EDICAO da revista");
            int numeroDaEdicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, informe o ANO DE PUBLICACAO da revista");
            string ano = Convert.ToString(Console.ReadLine());

            telaCaixa.VisualizarRegistros(false);
            
            Console.WriteLine("Por favor, informe o ID da CAIXA da revista");
            int idCaixa = Convert.ToInt32(Console.ReadLine());
            Caixa caixaSelecionada = (Caixa)repositorio.SelecionaPorId(idCaixa);

            bool status = false;

            return new Revista(titulo, numeroDaEdicao, ano, caixaSelecionada, status);
        }

        public override void VisualizarRegistros(bool verTudo)
        {
            Console.WriteLine("Visualizando Revistas");

            Console.WriteLine();

            Console.WriteLine(
             "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20} | {5, -15}",
             "Id", "Titulo", "Numero da Edicao", "Ano", "Caixa", "Emprestada ?"
         );

            ArrayList revistasCadastradas = repositorio.PegaRegistros();

            foreach (Revista revista in revistasCadastradas)
            {
                Console.WriteLine(
               "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20} | {5, -15}",
                revista.id, revista.Titulo, revista.NumeroDaEdicao,
                revista.Ano, revista.Caixa, revista.Status
              );
            }

            Console.ReadLine();
            Console.WriteLine();
        }
    }
}