using EmissorFiscal.Enums;
using System.Text;

namespace EmissorFiscal.Models
{
    internal class NFCe : NotaFiscal
    {

        public Guid Id { get; }
        public TipoNota Tipo { get; set; }
        public List<Produto> produtos = new List<Produto>();

        public NFCe()
        {
            Id = Guid.NewGuid();
            Tipo = TipoNota.NFC_e;
        }

        public void AdicionarProdutos(Produto produto)
        {
            produtos.Add(produto);
        }

        public override void EmitirNota()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("══════════════════════════════════════════════");
            sb.AppendLine("           NOTA FISCAL DE CONSUMIDOR");
            sb.AppendLine("══════════════════════════════════════════════");

            sb.AppendLine($"Número da Nota : {NumeroNota}");
            sb.AppendLine($"Data Emissão   : {DataEmissao:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"ID da Nota     : {Id}");

            sb.AppendLine();
            sb.AppendLine("► DADOS DO CLIENTE");
            sb.AppendLine("----------------------------------------------");
            sb.AppendLine($"Nome           : {Cliente.Nome}");
            sb.AppendLine($"E-mail         : {Cliente.Email}");
            sb.AppendLine($"Tipo Pessoa    : {Cliente.TipoPessoa}");
            sb.AppendLine($"CPF/CNPJ       : {Cliente.CpfCnpj}");

            sb.AppendLine();
            sb.AppendLine("► ENDEREÇO");
            sb.AppendLine("----------------------------------------------");
            sb.AppendLine($"Logradouro     : {Cliente.Logradouro}");
            sb.AppendLine($"Bairro         : {Cliente.Bairro}");
            sb.AppendLine($"Cidade/UF      : {Cliente.Cidade} - {Cliente.Uf}");
            sb.AppendLine($"CEP            : {Cliente.Cep}");

            sb.AppendLine();
            sb.AppendLine("► PRODUTOS");
            sb.AppendLine("----------------------------------------------");

            decimal valorTotalNota = 0;

            foreach (Produto pro in produtos)
            {
                sb.AppendLine($"Produto        : {pro.Nome}");
                sb.AppendLine($"Descrição      : {pro.Descricao}");
                sb.AppendLine($"Quantidade     : {pro.Quantidade}");
                sb.AppendLine($"NCM            : {pro.Ncm}");
                sb.AppendLine($"Código Produto : {pro.CodigoProduto}");
                sb.AppendLine($"Código Barras  : {pro.CodigoDeBarras}");
                sb.AppendLine($"Preço Unitário : {pro.PrecoUnitario:C}");
                sb.AppendLine($"Valor Total    : {pro.ValorTotal:C}");

                sb.AppendLine("----------------------------------------------");

                valorTotalNota += pro.ValorTotal;
            }

            sb.AppendLine();
            sb.AppendLine("► RESUMO");
            sb.AppendLine("----------------------------------------------");
            sb.AppendLine($"VALOR TOTAL DA NOTA: {valorTotalNota:C}");

            sb.AppendLine("══════════════════════════════════════════════");

            return sb.ToString();
        }
    }
}
