using System.Collections;
using ClubeDaLeitura.ConsoleApp.Base;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;


namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class Caixa : EntidadeBase
    {
        public string Etiqueta { get; set; }
        public string Cor { get; set; }
        public int TempoDeEmprestimo { get; set; }
        public ArrayList Revistas { get; set; } = new ArrayList();

        public Caixa(string etiqueta, string cor, int tempoDeEmprestimo)
        {
            Etiqueta = etiqueta;
            Cor = cor;
            TempoDeEmprestimo = tempoDeEmprestimo;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Caixa registroNovo = (Caixa)novoRegistro;

            this.Etiqueta = registroNovo.Etiqueta;
            this.Cor = registroNovo.Cor;
            this.TempoDeEmprestimo = registroNovo.TempoDeEmprestimo;
        }
    }
}