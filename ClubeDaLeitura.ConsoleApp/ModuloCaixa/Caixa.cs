using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class Caixa : EntidadeBase
    {
        public string Etiqueta { get; set; }
        public string Cor { get; set; }
        public int TmpoDeEmprestimo { get; set; }
        public Revista Revistas { get; set; }

        public Revista Revista
        {
            get => default;
            set
            {
            }
        }

        public Caixa(string etiqueta, string cor, int tmpoDeEmprestimo, Revista revistas)
        {
            Etiqueta = etiqueta;
            Cor = cor;
            TmpoDeEmprestimo = tmpoDeEmprestimo;
            Revistas = revistas;
        }
    }
}