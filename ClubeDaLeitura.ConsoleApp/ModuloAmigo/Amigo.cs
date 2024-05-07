using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloReserva;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class Amigo : EntidadeBase
    {
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public Reserva Reserva { get; set; }
        public Emprestimo Emprestimo { get; set; }

        public Amigo(string nome, string responsavel, int telefone, string endereco, Reserva reserva, Emprestimo emprestimo)
        {
            Nome = nome;
            Responsavel = responsavel;
            Telefone = telefone;
            Endereco = endereco;
            Reserva = reserva;
            Emprestimo = emprestimo;
        }

    }
}