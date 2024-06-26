﻿using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo.Multa;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Emprestimo;
using ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Reserva;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            TelaAmigo telaAmigo = new TelaAmigo();
            telaAmigo.tipoEntidade = "Amigo";
            telaAmigo.repositorio = repositorioAmigo;

            RepositorioMulta repositorioMulta = new RepositorioMulta();
            TelaMulta telaMulta = new TelaMulta();
            telaMulta.tipoEntidade = "Multa";
            telaMulta.repositorio = repositorioMulta;

            telaMulta.telaAmigo = telaAmigo;
            telaMulta.repositorioAmigo = repositorioAmigo;

            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            TelaCaixa telaCaixa = new TelaCaixa();
            telaCaixa.tipoEntidade = "Caixa";
            telaCaixa.repositorio = repositorioCaixa;


            RepositorioRevista repositorioRevista = new RepositorioRevista();
            TelaRevista telaRevista = new TelaRevista();
            telaRevista.tipoEntidade = "Revista";
            telaRevista.repositorio = repositorioRevista;

            telaRevista.telaCaixa = telaCaixa;
            telaRevista.repositorioCaixa = repositorioCaixa;

            telaCaixa.telaRevista = telaRevista;
            telaCaixa.repositorioRevista = repositorioRevista;

            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            TelaEmprestimo telaEmprestimo = new TelaEmprestimo();
            telaEmprestimo.tipoEntidade = "Emprestimo";
            telaEmprestimo.repositorio = repositorioEmprestimo;

            telaEmprestimo.telaAmigo = telaAmigo;
            telaEmprestimo.telaRevista = telaRevista;
            telaEmprestimo.telaMulta = telaMulta;

            telaEmprestimo.repositorioAmigo = repositorioAmigo;
            telaEmprestimo.repositorioRevista = repositorioRevista;
            telaEmprestimo.repositorioMulta = repositorioMulta;

            telaAmigo.CadastroTeste();
            telaCaixa.CadastroTeste();
            telaRevista.CadastroTeste();
            telaEmprestimo.CadastroTeste();

            RepositorioReserva repositorioReserva = new RepositorioReserva();
            TelaReserva telaReserva = new TelaReserva();
            telaReserva.tipoEntidade = "Reserva";
            telaReserva.repositorio = repositorioReserva;
            telaReserva.telaRevista = telaRevista;
            telaReserva.telaAmigo = telaAmigo;
            telaReserva.repositorioAmigo = repositorioAmigo;
            telaReserva.repositorioRevista = repositorioRevista;



            while (true)
            {
                char opcaoPrincipalEscolhida = TelaPrincipal.ApresentarMenuPrincipal();

                if (opcaoPrincipalEscolhida == 'S' || opcaoPrincipalEscolhida == 's')
                    break;

                TelaBase tela = null;

                if (opcaoPrincipalEscolhida == '1')
                    tela = telaAmigo;

                else if (opcaoPrincipalEscolhida == '2')
                    tela = telaCaixa;

                else if (opcaoPrincipalEscolhida == '3')
                    tela = telaEmprestimo;

                else if (opcaoPrincipalEscolhida == '4')
                    tela = telaReserva;

                else if (opcaoPrincipalEscolhida == '5')
                    tela = telaRevista;

                while (true)
                {
                    char operacaoEscolhida = tela.ApresentarMenu();

                    if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                        break;

                    if (operacaoEscolhida == '1')
                        tela.Registrar();

                    else if (operacaoEscolhida == '2')
                        tela.Editar();

                    else if (operacaoEscolhida == '3')
                        tela.Excluir();

                    else if (operacaoEscolhida == '4')
                        tela.VisualizarRegistros(true);

                    else if (operacaoEscolhida == '5')
                    {
                        if (tela.tipoEntidade == "Caixa")
                        {
                            TelaCaixa telaConvertida = (TelaCaixa)tela;
                            telaConvertida.VisualizarRevistas();
                        }

                        else if (tela.tipoEntidade == "Amigo")
                        {
                            while (true)
                            {
                                tela = telaMulta;
                                operacaoEscolhida = tela.ApresentarMenu();

                                if (operacaoEscolhida == 'S' || operacaoEscolhida == 's')
                                {
                                    tela = telaAmigo;
                                    break;
                                }

                                if (operacaoEscolhida == '1')
                                {
                                    tela.VisualizarRegistros(true);
                                }
                                else if (operacaoEscolhida == '2')
                                {

                                }

                                else
                                    continue;

                            }

                        }

                        else if (tela.tipoEntidade == "Emprestimo")
                        {
                            TelaEmprestimo telaConvertida = (TelaEmprestimo)tela;
                            telaConvertida.FinalizarEmprestimo();
                        }

                        else
                            continue;

                    }
                }
            }
        }
    }
}
