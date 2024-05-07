using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    public class Multa
    {
        public int TempoDecorrido { get; set; }
        public int Valor { get; set; }
        public int Revista { get; set; }
        public Amigo Amigo { get; set; }

        public Multa(int tempoDecorrido, int valor, int revista, Amigo amigo)
        {
            TempoDecorrido = tempoDecorrido;
            Valor = valor;
            Revista = revista;
            Amigo = amigo;
        }
    }
}