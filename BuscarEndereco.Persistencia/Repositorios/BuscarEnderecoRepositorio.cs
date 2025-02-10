using BuscarEndereco.Core.Interfaces.Repositorios;
using BuscarEndereco.Core.Modelos;

namespace BuscarEndereco.Persistencia.Repositorios
{
    public class BuscarEnderecoRepositorio : IBuscarEnderecoRepositorio
    {
        private List<Endereco> Enderecos = new List<Endereco>();

        public async Task SalvarEndereco(Endereco endereco)
        {
            Endereco.Add(endereco);
        }

        public Task<Endereco> ProcurarEndereco(string cep)
        {
            throw new NotImplementedException();
        }
    }
}
