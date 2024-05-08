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

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Amigo registroNovo = (Amigo)novoRegistro;

            this.Nome = registroNovo.Nome;
            this.Responsavel = registroNovo.Responsavel;
            this.Telefone = registroNovo.Telefone;
            this.Endereco = registroNovo.Endereco;
            this.Reserva = registroNovo.Reserva;
            this.Emprestimo = registroNovo.Emprestimo;
        }
    }
}