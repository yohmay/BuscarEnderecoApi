namespace BuscarEndereco.Core.Modelos
{
    public class Endereco
    {
        public Endereco(string cep, string rua, string complemento, string cidade, string uf, string estado, string regiao, string ddd)
        {
            Cep = cep;
            Rua = rua;
            Complemento = complemento;
            Cidade = cidade;
            Uf = uf;
            Estado = estado;
            Regiao = regiao;
            Ddd = ddd;
        }

        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Estado { get; set; }
        public string Regiao { get; set; }
        public string Ddd { get; set; }
    }
}
