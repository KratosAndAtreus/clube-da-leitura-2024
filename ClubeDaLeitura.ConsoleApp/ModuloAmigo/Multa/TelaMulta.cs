using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo.Multa
{
    internal class TelaMulta : TelaBase
    {
        public TelaAmigo telaAmigo = null;

        public RepositorioAmigo repositorioAmigo = null;
        public override void VisualizarRegistros(bool verTudo)
        {
            telaAmigo.VisualizarRegistros(true);

            Console.WriteLine("Digite o id da Caixa desejada");
            int idAmigo = Convert.ToInt32(Console.ReadLine());
            Amigo amigoSelecionado = (Amigo)repositorioAmigo.SelecionaPorId(idAmigo);

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -20} | {3, -20} | {4, -20}",
                "Id", "Tempo decorrido", "Valor", "Revista", "Amigo"
            );

            foreach (Amigo multas in amigoSelecionado.Multas)
            {
                Console.WriteLine("Teste");
                //Console.WriteLine(
                //    "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20} | {5, -15}",
                //    multas.id, multas.TempoDecorrido, multas.Valor,
                //    multas.Revista, multas.Amigo
                //);
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        public Multa GeraMulta(int tempoDecorrido, string revista, string amigo)
        {
            return new Multa(tempoDecorrido, revista, amigo);
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
