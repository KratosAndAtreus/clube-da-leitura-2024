using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo.Multa;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Emprestimo
{
    internal class TelaEmprestimo : TelaBase
    {
        public TelaAmigo telaAmigo = null;
        public TelaRevista telaRevista = null;
        public TelaMulta telaMulta = null;

        public RepositorioAmigo repositorioAmigo = null;
        public RepositorioRevista repositorioRevista = null;
        public RepositorioMulta repositorioMulta = null;

        protected override EntidadeBase ObterRegistro()
        {
            telaAmigo.VisualizarRegistros(false);

            Console.WriteLine("Por favor, informe o ID do AMIGO");
            int idAmigo = Convert.ToInt32(Console.ReadLine());
            Amigo amigoSelecionado = (Amigo)repositorioAmigo.SelecionaPorId(idAmigo);


            telaRevista.VisualizarRegistros(false);

            Console.WriteLine("Por favor, informe ID da revista");
            int idRevista = Convert.ToInt32(Console.ReadLine());
            Revista revistaSelecionada = (Revista)repositorioRevista.SelecionaPorId(idRevista);


            DateTime dataDeDevolucao = DateTime.Now.AddDays(telaRevista.PegaCaixa(idRevista));

            bool status = true;

            Emprestimo novoEmprestimo = new Emprestimo(amigoSelecionado, revistaSelecionada, DateTime.Now, dataDeDevolucao, status);

            return novoEmprestimo;
        }

        public override void VisualizarRegistros(bool verTudo)
        {
            Console.WriteLine("Visualizando Revistas");

            Console.WriteLine();

            Console.WriteLine(
             "{0, -10} | {1, -15} | {2, -20} | {3, -20} | {4, -20} | {5, -15}",
             "Id", "Amigo", "Revista", "Data do Emprestimo", "Data de Devolução", "Status"
         );

            List<EntidadeBase> EmprestimosCadastrados = repositorio.PegaRegistros();

            foreach (Emprestimo emprestimo in EmprestimosCadastrados)
            {
                Console.WriteLine(
               "{0, -10} | {1, -15} | {2, -20} | {3, -20} | {4, -20} | {5, -15}",
                emprestimo.id,
                emprestimo.Amigo.Nome,
                emprestimo.Revista.Titulo,
                emprestimo.DataDeEmprestimo.ToShortDateString(),
                emprestimo.DataDeDevolucao.ToShortDateString(),
                emprestimo.StatusDoEmprestimo
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
            Console.WriteLine($"5 - Finallizar {tipoEntidade}");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;
        }

        public void FinalizarEmprestimo()
        {
            VisualizarRegistros(true);
            Console.WriteLine("Digite o ID do Emprestimo desejado");
            int idEmprestimo = Convert.ToInt32(Console.ReadLine());
            Emprestimo emprestimoSelecionado = (Emprestimo)repositorio.SelecionaPorId(idEmprestimo);

            VerificaAtraso(idEmprestimo);

            ExibirMensagem("Emprestimo finalizado", ConsoleColor.Red);

        }

        public bool VerificaAtraso(int idEmprestimo)
        {
            bool status = false;
            List<EntidadeBase> emprestimosCadastrados = repositorio.PegaRegistros();

            foreach (Emprestimo emprestimo in emprestimosCadastrados)
            {
                TimeSpan tempoDecorrido = emprestimo.DataDeEmprestimo - DateTime.Now;
                int valorDaMulta = 5 * tempoDecorrido.Days;
                if (emprestimo.id != idEmprestimo)
                    continue;
                else
                {
                    if (emprestimo.DataDeDevolucao < DateTime.Now)
                    {
                        emprestimo.StatusDoEmprestimo = true;
                        Multa novaMulta = telaMulta.GeraMulta(valorDaMulta, emprestimo.Revista.Titulo, emprestimo.Amigo.Nome);

                        emprestimo.Amigo.ReceberMulta(novaMulta);
                    }
                    else
                    {
                        emprestimo.StatusDoEmprestimo = false;
                    }

                    break;
                }
            }
            return status;
        }

        public void CadastroTeste()
        {
            Amigo amigoSelecionado = (Amigo)repositorioAmigo.SelecionaPorId(0);
            Revista revistaSelecionada = (Revista)repositorioRevista.SelecionaPorId(0);
            //DateTime dataDeEmprestimo = Convert.ToDateTime("12/12/2002");
            DateTime dataDeDevolucao = DateTime.Now.AddDays(telaRevista.PegaCaixa(0));
            Emprestimo emprestimoTeste = new Emprestimo(amigoSelecionado, revistaSelecionada, DateTime.Now, dataDeDevolucao, true);

            repositorio.Cadastrar(emprestimoTeste);
        }
    }
}
