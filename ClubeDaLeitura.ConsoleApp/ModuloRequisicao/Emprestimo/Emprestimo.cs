using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloAmigo;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloRequisicao.Emprestimo
{
    public class Emprestimo : EntidadeBase
    {
        public Amigo Amigo { get; set; }
        public Revista Revista { get; set; }
        public DateTime DataDeEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }
        public bool StatusDoEmprestimo { get; set; }

        public Emprestimo(Amigo amigo, Revista revista, DateTime dataDeEmprestimo, bool statusDoEmprestimo)
        {
            Amigo = amigo;
            Revista = revista;
            DataDeEmprestimo = dataDeEmprestimo;
            StatusDoEmprestimo = statusDoEmprestimo;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Emprestimo registroNovo = (Emprestimo)novoRegistro;

            Amigo = registroNovo.Amigo;
            Revista = registroNovo.Revista;
            DataDeEmprestimo = registroNovo.DataDeEmprestimo;
            DataDeDevolucao = registroNovo.DataDeDevolucao;
            StatusDoEmprestimo = registroNovo.StatusDoEmprestimo;
        }
    }
}