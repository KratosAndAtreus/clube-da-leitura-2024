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
        public string Ano { get; set; }
        public Caixa Caixa { get; set; }
        public bool Status { get; set; }

        public Revista(string titulo, int numeroDaEdicao, string ano, Caixa caixa, bool status)
        {
            Titulo = titulo;
            NumeroDaEdicao = numeroDaEdicao;
            Ano = ano;
            Caixa = caixa;
            Status = status;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Revista registroNovo = (Revista)novoRegistro;

            this.Titulo = registroNovo.Titulo;
            this.NumeroDaEdicao = registroNovo.NumeroDaEdicao;
            this.Ano = registroNovo.Ano;
            this.Caixa = registroNovo.Caixa;
            this.Status = registroNovo.Status;
        }
    }
}