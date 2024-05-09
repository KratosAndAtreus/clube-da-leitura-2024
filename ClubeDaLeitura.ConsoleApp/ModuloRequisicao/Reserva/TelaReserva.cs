﻿using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Reserva
{
    internal class TelaReserva : TelaBase
    {
        public TelaRevista telaRevista;
        public RepositorioRevista repositorioRevista ;

        public TelaAmigo telaAmigo;
        public RepositorioAmigo repositorioAmigo;

        public override void VisualizarRegistros(bool verTudo)
        {
            Console.WriteLine("Visualizando Reservas");

            Console.WriteLine();

            Console.WriteLine(
           "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20} | {5, -20}",
           "Id", "Revista", "Data da reserva", "Amigo", "Status da reserva, Data Limite"
       );

            ArrayList reservasCadastradas = repositorio.PegaRegistros();

            foreach (Reserva reserva in reservasCadastradas)
            {
                Console.WriteLine(
               "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20} | {5, -20}",
                reserva.id, reserva.Revista.Titulo,reserva.DataDaReserva,
                reserva.Amigo.Nome, reserva.StatusDaReserva, reserva.DataLimite
              );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        protected override EntidadeBase ObterRegistro()
        {
            telaRevista.VisualizarRegistros(false);
            Console.WriteLine();
            Console.WriteLine("Por favor, informe o ID da REVISTA a ser retirada");
            int idRevista = Convert.ToInt32(Console.ReadLine());
            Revista revistaSelecionada = (Revista)repositorioRevista.SelecionaPorId(idRevista);
            revistaSelecionada.Status = true;

            telaAmigo.VisualizarRegistros(false);
            Console.WriteLine();
            Console.WriteLine("Por favor, informe o ID do AMIGO que vai retirar a REVISTA");
            int idAmigo = Convert.ToInt32(Console.ReadLine());
            Amigo amigoSelecionado = (Amigo)repositorioAmigo.SelecionaPorId(idAmigo);

            DateTime dataLimite = DateTime.Now.AddDays(2);
            bool status = false;

            return new Reserva(revistaSelecionada, DateTime.Now, dataLimite, amigoSelecionado, status);
        }
    }


}
