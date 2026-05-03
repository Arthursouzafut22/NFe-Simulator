using EmissorFiscal.Enums;
using EmissorFiscal.Models;

namespace EmissorFiscal.Ui
{
    class TelaCliente
    {

        public Cliente Cliente { get; set; }
        public void ColetarDadosCliente()
        {
            Console.Write("Digite Nome do tomador/cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite E-mail do tomador/cliente: ");
            string email = Console.ReadLine();
            Console.Write("Pessoa Juridica ou Fisica (F/J)?: ");
            string tipo = Console.ReadLine().ToUpper();
            TipoPessoa tipoPessoa = tipo == "F" ? TipoPessoa.Fisica : TipoPessoa.Juridica;
            string? cpfCnpj = null;


            switch (tipoPessoa)
            {
                case TipoPessoa.Fisica:
                    Console.Write("Digite o CPF do tomador/cliente: ");
                    cpfCnpj = Console.ReadLine();
                    break;

                case TipoPessoa.Juridica:
                    Console.Write("Digite o CNPJ do tomador/cliente: ");
                    cpfCnpj = Console.ReadLine();
                    break;
            }

            Console.WriteLine("...Endereço do tomador/cliente...");
            Console.Write("Digite o uf: ");
            string uf = Console.ReadLine();
            Console.Write("Digite a cidade: ");
            string cidade = Console.ReadLine();
            Console.Write("Digite o bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Digite o logradouro: ");
            string logradouro = Console.ReadLine();
            Console.Write("Digite o cep: ");
            string cep = Console.ReadLine();
            this.Cliente = new Cliente(nome, email, tipoPessoa, cpfCnpj, uf, cidade, bairro, logradouro, cep);
        }
    }
}
