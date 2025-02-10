using BuscarEndereco.Core.Interfaces;
using BuscarEndereco.Core.Interfaces.Repositorios;
using BuscarEndereco.Core.Modelos;

namespace BuscarEndereco.Core.Servicos
{
    public class BuscarEnderecoServico : IBuscarEnderecoServico
    {
        protected IBuscarEnderecoRepositorio BuscarEnderecoRepositorio { get; }

        public BuscarEnderecoServico(IBuscarEnderecoRepositorio buscarEnderecoRepositorio)
        {
            BuscarEnderecoRepositorio = buscarEnderecoRepositorio;
        }

        public async Task SalvarEndereco(Endereco endereco)
        {
            await BuscarEnderecoRepositorio.SalvarEndereco(endereco);
        }

        public async Task<Endereco> ProcurarEndereco(string cep)
        {
           return await BuscarEnderecoRepositorio.ProcurarEndereco(cep);
        }
    }
}
