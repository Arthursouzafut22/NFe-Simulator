using EmissorFiscal.Enums;
namespace EmissorFiscal.Models
{
    class NFSe : NotaFiscal
    {
        public Guid Id { get; private set; }
        public TipoNota Tipo { get; set; }
        public Servico Servico { get; set; }

        public NFSe()
        {
            Id = Guid.NewGuid();
        }

        //public void MenuInformacoesNfseServico()
        //{
        //    Console.Write("Digite Nome do tomador: ");
        //    string nome = Console.ReadLine();
        //    Console.Write("Digite E-mail do tomador: ");
        //    string email = Console.ReadLine();
        //    Console.Write("Pessoa Jurdica ou Fisica (F/J)?: ");
        //    string tipo = Console.ReadLine().ToUpper();
        //    TipoPessoa tipoPessoa = tipo == "F" ? TipoPessoa.Fisica : TipoPessoa.Juridica;
        //    string? cpfCnpj = null;


        //    switch (tipoPessoa)
        //    {
        //        case TipoPessoa.Fisica:
        //            Console.Write("Digite o CPF do tomador: ");
        //            cpfCnpj = Console.ReadLine();
        //            break;

        //        case TipoPessoa.Juridica:
        //            Console.Write("Digite o CNPJ do tomador: ");
        //            cpfCnpj = Console.ReadLine();
        //            break;
        //    }

        //    Console.WriteLine("...Endereço do tomador...");
        //    Console.Write("Digite o uf: ");
        //    string uf = Console.ReadLine();
        //    Console.Write("Digite a cidade: ");
        //    string cidade = Console.ReadLine();
        //    Console.Write("Digite o bairro: ");
        //    string bairro = Console.ReadLine();
        //    Console.Write("Digite o logradouro: ");
        //    string logradouro = Console.ReadLine();
        //    Console.Write("Digite o cep: ");
        //    string cep = Console.ReadLine();
        //    this.Cliente = new Cliente(nome, email, tipoPessoa, cpfCnpj, uf, cidade, bairro, logradouro, cep);
        //}


        public override void EmitirNota()
        {
            Console.Write("Emitindo nota....");
        }

        public override string ToString()
        {
            return "";
        }
    }
}
