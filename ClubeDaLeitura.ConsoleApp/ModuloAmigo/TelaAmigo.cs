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

        public override char ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"        Gestão de {tipoEntidade}s        ");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine($"1 - Cadastrar {tipoEntidade}");
            Console.WriteLine($"2 - Editar {tipoEntidade}");
            Console.WriteLine($"3 - Excluir {tipoEntidade}");
            Console.WriteLine($"4 - Visualizar {tipoEntidade}s");
            Console.WriteLine($"5 - Gerenciar Multas do {tipoEntidade}");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;
        }

        public char MenuMulta()
        {

            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"        Gestão de {tipoEntidade}s        ");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine($"1 - visualizar Multas");
            Console.WriteLine($"2 - Pagar Multas");

            Console.WriteLine("S - Voltar");

            Console.WriteLine();

            Console.Write("Escolha uma das opções: ");
            char operacaoEscolhida = Convert.ToChar(Console.ReadLine());

            return operacaoEscolhida;
        }


        public void CadastroTeste()
        {
            Amigo amigoTeste = new Amigo("Fulano", "Beltrano", "32220011", "Rua Vasco da Gama");

            repositorio.Cadastrar(amigoTeste);
        }

    }
}
