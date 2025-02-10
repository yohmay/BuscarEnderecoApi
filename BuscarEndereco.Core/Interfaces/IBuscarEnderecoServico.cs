using BuscarEndereco.Core.Modelos;

namespace BuscarEndereco.Core.Interfaces
{
    public interface IBuscarEnderecoServico
    {
        Task SalvarEndereco(Endereco endereco);
        Task<Endereco> ProcurarEndereco(string cep);
    }
}
