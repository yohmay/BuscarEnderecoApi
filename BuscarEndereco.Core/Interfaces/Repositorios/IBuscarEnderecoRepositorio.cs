using BuscarEndereco.Core.Modelos;

namespace BuscarEndereco.Core.Interfaces.Repositorios
{
    public interface IBuscarEnderecoRepositorio
    {
        Task SalvarEndereco(Endereco endereco);
        Task<Endereco> ProcurarEndereco(string cep);
    }
}
