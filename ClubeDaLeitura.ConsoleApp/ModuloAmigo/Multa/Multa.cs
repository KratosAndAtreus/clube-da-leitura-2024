using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo.Multa
{
    public class Multa : EntidadeBase
    {
        public int TempoDecorrido { get; set; }
        public int Valor { get; set; }
        public string Revista { get; set; }
        public string Amigo { get; set; }

        public Multa(int tempoDecorrido, string revista, string amigo)
        {
            TempoDecorrido = tempoDecorrido;
            Valor = 5;
            Revista = revista;
            Amigo = amigo;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }
    }
}