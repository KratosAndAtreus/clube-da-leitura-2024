using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloEmprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloReserva;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            TelaAmigo telaAmigo = new TelaAmigo();
            
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            

            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();

            RepositorioReserva repositorioReserva = new RepositorioReserva();

            RepositorioRevista repositorioRevista = new RepositorioRevista();

            while (true)
            {
                char opcaoPrincipalEscolhida = TelaPrincipal.ApresentarMenuPrincipal();

                if (opcaoPrincipalEscolhida == 'S' || opcaoPrincipalEscolhida == 's')
                    break;

                TelaBase tela = null;

                //if (opcaoPrincipalEscolhida == '1')
                //    tela = telaAmigo;

                //else if (opcaoPrincipalEscolhida == '2')
                //    tela = telaCaixa;

                //else if (opcaoPrincipalEscolhida == '3')
                //    tela = telaEmprestimo;

                //else if (opcaoPrincipalEscolhida == '4')
                //    tela = telaReserva;

                //else if (opcaoPrincipalEscolhida == '5')
                //    tela = telaRevista;

                char operacaoEscolhida = tela.ApresentarMenu();

                if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                    continue;

                if (operacaoEscolhida == '1')
                    tela.Registrar();

                else if (operacaoEscolhida == '2')
                    tela.Editar();

                else if (operacaoEscolhida == '3')
                    tela.Excluir();

                else if (operacaoEscolhida == '4')
                    continue;//tela.VisualizarRegistros(true);
            }
        }
    }
}
