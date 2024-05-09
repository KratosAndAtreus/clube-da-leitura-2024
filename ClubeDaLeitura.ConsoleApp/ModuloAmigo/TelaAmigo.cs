using ClubeDaLeitura.ConsoleApp.Base;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.ModuloAmigo
{
    internal class TelaAmigo : TelaBase
    {
        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Por favor, informe o NOME do amigo");
            string nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor, informe o RESPONSAVEL");
            string responsavel = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor, informe o TELEFONE ");
            string telefone = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor, informe o ENDERECO");
            string endereco = Convert.ToString(Console.ReadLine());

            return new Amigo(nome, responsavel, telefone, endereco);
        }

        public override void VisualizarRegistros(bool verTudo)
        {
            Console.WriteLine("Visualizando amigos");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20}",
                "Id", "Nome", "Responsavel", "Telefone", "Endereco"
            );

            ArrayList amigosCadastrados = repositorio.PegaRegistros();

            foreach (Amigo amigo in amigosCadastrados)
            {
                Console.WriteLine(
               "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20}",
                amigo.id, amigo.Nome, amigo.Responsavel, amigo.Telefone, amigo.Endereco
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        public void CadastroTeste()
        {
            Amigo amigoTeste = new Amigo("Fulano", "Beltrano", "32220011", "Rua Vasco da Gama");

            repositorio.Cadastrar(amigoTeste);
        }

    }
}
