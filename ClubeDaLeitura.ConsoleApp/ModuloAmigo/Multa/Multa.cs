using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo.Multa
{
    public class Multa : EntidadeBase
    {
        public int TempoDecorrido { get; set; }
        public int Valor { get; set; }
        public Revista Revista { get; set; }
        public Amigo Amigo { get; set; }

        public Multa(int tempoDecorrido, int valor, Revista revista, Amigo amigo)
        {
            TempoDecorrido = tempoDecorrido;
            Valor = valor;
            Revista = revista;
            Amigo = amigo;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }
    }
}