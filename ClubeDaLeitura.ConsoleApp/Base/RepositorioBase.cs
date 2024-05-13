using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.Base
{
    internal class RepositorioBase
    {
        protected List<EntidadeBase> registros = new();

        protected int contadorId = 0;

        public void Cadastrar(EntidadeBase novoRegistro)
        {
            novoRegistro.id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, EntidadeBase novaEntidade)
        {
            novaEntidade.id = id;

            foreach (EntidadeBase registro in registros)
            {
                if (registro.id == id)
                {
                    registro.AtualizarRegistro(novaEntidade);

                    return true;
                }
            }
            return false;
        }

        public bool Excluir(int id)
        {

            foreach (EntidadeBase registro in registros)
            {
                if (registro.id == id)
                {
                    registros.Remove(registro);

                    return true;
                }
            }
            return false;
        }

        public List<EntidadeBase> PegaRegistros()
        {
            return registros;
        }

        public EntidadeBase SelecionaPorId(int id)
        {
            foreach (EntidadeBase registro in registros)
            {
                if (registro.id == id)
                {
                    return registro;
                }
            }
            return null;
        }

        public bool Existe(int id)
        {
            foreach (EntidadeBase registro in registros)
            {
                if (registro.id == id)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
