using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloReserva;

namespace ClubeDaLeitura.ConsoleApp.ModuloRevista
{
    public class Revista : EntidadeBase
    {
        public string Titulo { get; set; }
        public int NumeroDaEdicao { get; set; }
        public DateTime Ano { get; set; }
        public Caixa Caixa { get; set; }
        public bool Status { get; set; }
        public Reserva Reserva { get; set; }
        public Emprestimo Emprestimo { get; set; }

        public Revista(string titulo, int numeroDaEdicao, DateTime ano, Caixa caixa, bool status, Reserva reserva, Emprestimo emprestimo)
        {
            Titulo = titulo;
            NumeroDaEdicao = numeroDaEdicao;
            Ano = ano;
            Caixa = caixa;
            Status = status;
            Reserva = reserva;
            Emprestimo = emprestimo;
        }
    }
}