using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Emprestimo : EntidadeBase
    {
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public System.DateTime DataDeEmprestimo { get; set; }
        public System.DateTime DataDeDevolucao { get; set; }
        public bool StatusDoEmprestimo { get; set; }

        public Emprestimo(Amigo amigo, Revista revista, DateTime dataDeEmprestimo, DateTime dataDeDevolucao, bool statusDoEmprestimo)
        {
            Amigo = amigo;
            Revista = revista;
            DataDeEmprestimo = dataDeEmprestimo;
            DataDeDevolucao = dataDeDevolucao;
            StatusDoEmprestimo = statusDoEmprestimo;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Emprestimo registroNovo = (Emprestimo)novoRegistro;

            this.Amigo = registroNovo.Amigo;
            this.Revista = registroNovo.Revista;
            this.DataDeEmprestimo = registroNovo.DataDeEmprestimo;
            this.DataDeDevolucao = registroNovo.DataDeDevolucao;
            this.StatusDoEmprestimo = registroNovo.StatusDoEmprestimo;
        }
    }
}