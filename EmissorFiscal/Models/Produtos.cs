namespace EmissorFiscal.Models
{
    class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CodigoProduto { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Ncm { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal => PrecoUnitario * Quantidade;

        public Produto(
            string nome,
            string descricao,
            string codigoProduto,
            string codigoDeBarras,
            string ncm,
            decimal precoUnitario,
            int quantidade)
        {
            Nome = nome;
            Descricao = descricao;
            CodigoProduto = codigoProduto;
            CodigoDeBarras = codigoDeBarras;
            Ncm = ncm;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }
    }
}