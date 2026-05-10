using EmissorFiscal.Enums;
using System.Text;
namespace EmissorFiscal.Models
{
    class NFSe : NotaFiscal
    {
        public Guid Id { get; private set; }
        public Servico Servico { get; set; }

        public NFSe() {}
        public NFSe(decimal valorTotal, TipoNota tipoNota) : base(tipoNota, valorTotal)
        {
            Id = Guid.NewGuid();
        }

        public decimal CalcularTotalPisCofins()
        {
            return Servico.ValorPis + Servico.ValorCofins;
        }

        public decimal CalcularValorLiquidoDaNota()
        {
            return ValorTotal - CalcularTotalPisCofins();
        }

        public override void EmitirNota()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("========== NOTA FISCAL DE SERVIÇO ==========");
            sb.AppendLine($"Nº: {NumeroNota}    Data: {DataEmissao:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Tipo Nota: {TipoNota}");
            sb.AppendLine($"ID: {Id}");

            sb.AppendLine("\n--- DADOS DO TOMADOR ---");
            sb.AppendLine($"Nome:        {Cliente.Nome}");
            sb.AppendLine($"E-mail:      {Cliente.Email}");
            sb.AppendLine($"Tipo Pessoa: {Cliente.TipoPessoa}");
            sb.AppendLine($"CPF/CNPJ:    {Cliente.CpfCnpj}");

            sb.AppendLine("\n--- ENDEREÇO ---");
            sb.AppendLine($"{Cliente.Logradouro}, {Cliente.Bairro}");
            sb.AppendLine($"{Cliente.Cidade} - {Cliente.Uf} | CEP: {Cliente.Cep}");

            sb.AppendLine("\n--- DADOS DO SERVIÇO ---");
            sb.AppendLine($"Descrição:    {Servico.Descricao}");
            sb.AppendLine($"Alíquota ISS: {Servico.AliquotaIss}%");
            sb.AppendLine($"ISS Retido Fonte: {(Servico.IssRetidoFonte ? "SIM" : "NÃO")}");
            sb.AppendLine($"CNAE:             {Servico.Cnae}");
            sb.AppendLine($"Item Lista LC116: {Servico.ItemListaServicoLC116}");
            sb.AppendLine($"Cód. Mun. Serviço: {Servico.CodigoServicoMunicipio}");
            sb.AppendLine($"PIS/COFINS:   {Servico.ValorPis:C} / {Servico.ValorCofins:C}");

            sb.AppendLine("\n--- VALORES TOTAIS ---");
            sb.AppendLine($"VALOR BRUTO:   {ValorTotal:C}");
            sb.AppendLine($"VALOR LÍQUIDO: {CalcularValorLiquidoDaNota():C}");
            sb.AppendLine("============================================");

            return sb.ToString();
        }
    }
}
