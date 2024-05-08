﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;
using ClubeDaLeitura.ConsoleApp.ModuloReserva;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Revista registroNovo = (Revista) novoRegistro;

            this.Titulo = registroNovo.Titulo;
            this.NumeroDaEdicao = registroNovo.NumeroDaEdicao;
            this.Ano = registroNovo.Ano;
            this.Caixa = registroNovo.Caixa;
            this.Status = registroNovo.Status;
            this.Reserva = registroNovo.Reserva;
            this.Emprestimo = registroNovo.Emprestimo;
        }
    }
}