using EmissorFiscal.Enums;
using EmissorFiscal.Models;
using EmissorFiscal.Utils;

namespace EmissorFiscal.Ui
{
    class TelaCliente
    {
        public Cliente Cliente { get; set; }

        public void ColetarDadosCliente()
        {
            Console.Write("Digite o nome do tomador/cliente: ");
            string nome = Validador.LerCampoObrigatorio();

            Console.Write("Digite o e-mail do tomador/cliente: ");
            string email = Validador.ValidarEmail();

            Console.Write("Pessoa jurídica ou física (F/J)?: ");
            string tipo = Validador.LerCampoObrigatorio().ToUpper();

            TipoPessoa tipoPessoa = tipo == "F"
                ? TipoPessoa.Fisica
                : TipoPessoa.Juridica;

            string? cpfCnpj = null;

            switch (tipoPessoa)
            {
                case TipoPessoa.Fisica:
                    Console.Write("Digite o CPF do tomador/cliente: ");
                    cpfCnpj = Validador.LerCampoObrigatorio();
                    break;

                case TipoPessoa.Juridica:
                    Console.Write("Digite o CNPJ do tomador/cliente: ");
                    cpfCnpj = Validador.LerCampoObrigatorio();
                    break;
            }

            Console.WriteLine("...Endereço do tomador/cliente...");

            Console.Write("Digite a UF: ");
            string uf = Validador.LerCampoObrigatorio();

            Console.Write("Digite a cidade: ");
            string cidade = Validador.LerCampoObrigatorio();

            Console.Write("Digite o bairro: ");
            string bairro = Validador.LerCampoObrigatorio();

            Console.Write("Digite o logradouro: ");
            string logradouro = Validador.LerCampoObrigatorio();

            Console.Write("Digite o CEP: ");
            string cep = Validador.LerCampoObrigatorio();

            this.Cliente = new Cliente(
                nome,
                email,
                tipoPessoa,
                cpfCnpj,
                uf,
                cidade,
                bairro,
                logradouro,
                cep
            );
        }
    }
}
