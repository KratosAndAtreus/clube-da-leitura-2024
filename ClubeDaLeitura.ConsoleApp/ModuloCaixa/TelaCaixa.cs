using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    internal class TelaCaixa : TelaBase
    {
        public TelaRevista telaRevista = null;
        public RepositorioRevista repositorioRevista = null;

        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Por favor, informe a ETIQUETA da Caixa");
            string etiqueta = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor, informe a COR");
            string cor = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor, informe o TEMPO DE EMPRESTIMO ");
            int tempoDeEmprestimo = Convert.ToInt32(Console.ReadLine());

            return new Caixa(etiqueta, cor, tempoDeEmprestimo);
        }

        public override void VisualizarRegistros(bool verTudo)
        {
            Console.WriteLine("Visualizando amigos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -15} | {3, -5}",
                "Id", "Etiqueta", "Cor", "Tempo de Emprestimo"
            );

            List<EntidadeBase> caixasCadastradas = repositorio.PegaRegistros();

            foreach (Caixa caixa in caixasCadastradas)
            {
                Console.WriteLine(
               "{0, -10} | {1, -15} | {2, -15} | {3, -5}",
                caixa.id, caixa.Etiqueta, caixa.Cor, caixa.TempoDeEmprestimo
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        public override char ApresentarMenu()
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
            Console.WriteLine($"5 - Visualizar Revistas da {tipoEntidade}");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;
        }

        public void VisualizarRevistas()
        {
            VisualizarRegistros(false);

            Console.WriteLine("Digite o id da Caixa desejada");
            int idCaixa = Convert.ToInt32(Console.ReadLine());
            Caixa caixaSelecionada = (Caixa)repositorio.SelecionaPorId(idCaixa);

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20}",
                "Id", "Titulo", "Numero da Edicao", "Ano", "Emprestada ?"
            );

            foreach (Revista revista in caixaSelecionada.Revistas)
            {
                Console.WriteLine(
               "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20}",
                revista.id, revista.Titulo, revista.NumeroDaEdicao,
                revista.Ano, revista.Status
              );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        public void CadastroTeste()
        {
            Caixa caixaTeste = new Caixa("Teste", "Branca", 1);

            repositorio.Cadastrar(caixaTeste);
        }
    }
}