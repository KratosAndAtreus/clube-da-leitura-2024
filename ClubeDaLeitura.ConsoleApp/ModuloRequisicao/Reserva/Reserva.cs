using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Reserva
{
    public class Reserva : EntidadeBase
    {
        public Revista Revista { get; set; }
        public DateTime DataDaReserva { get; set; }
        public Amigo Amigo { get; set; }
        public bool StatusDaReserva { get; set; }

        public Reserva(Revista revista, DateTime dataDaReserva, Amigo amigo, bool statusDaReserva)
        {
            Revista = revista;
            DataDaReserva = dataDaReserva;
            Amigo = amigo;
            StatusDaReserva = statusDaReserva;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Reserva registroNovo = (Reserva)novoRegistro;

            Revista = registroNovo.Revista;
            DataDaReserva = registroNovo.DataDaReserva;
            Amigo = registroNovo.Amigo;
            StatusDaReserva = registroNovo.StatusDaReserva;
        }
    }
}