using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class Caixa : EntidadeBase
    {
        public string Etiqueta { get; set; }
        public string Cor { get; set; }
        public int TempoDeEmprestimo { get; set; }
        public Revista Revistas { get; set; }

        public Caixa(string etiqueta, string cor, int tempoDeEmprestimo, Revista revistas)
        {
            Etiqueta = etiqueta;
            Cor = cor;
            TempoDeEmprestimo = tempoDeEmprestimo;
            Revistas = revistas;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Caixa registroNovo = (Caixa)novoRegistro;

            this.Etiqueta = registroNovo.Etiqueta;
            this.Cor = registroNovo.Cor;
            this.TempoDeEmprestimo = registroNovo.TempoDeEmprestimo;
            this.Revistas = registroNovo.Revistas;
        }
    }
}