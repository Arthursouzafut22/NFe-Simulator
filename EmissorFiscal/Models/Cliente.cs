using EmissorFiscal.Enums;

namespace EmissorFiscal.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public TipoPessoa TipoPessoa { get; set; } // F = Física | J = Jurídica
        public string CpfCnpj { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }

        public Cliente(string nome, string email, TipoPessoa tipoPessoa,
            string cpfCnpj, string uf, string cidade,
            string bairro, string logradouro, string cep)
        {
            Nome = nome;
            Email = email;
            TipoPessoa = tipoPessoa;
            CpfCnpj = cpfCnpj;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Cep = cep;
        }
    }
}