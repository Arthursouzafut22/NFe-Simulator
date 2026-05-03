namespace EmissorFiscal.Models
{
    class Servico
    {
        public string Descricao { get; set; }
        public double AliquotaIss { get; set; }
        public bool IssRetidoFonte { get; set; }
        public string CodigoServicoMunicipio { get; set; }
        public string ItemListaServicoLC116 { get; set; }
        public string Cnae { get; set; }
        public string CodigoNbs { get; set; }
        public string MunicipioPrestacaoServico { get; set; }
        public decimal ValorPis { get; set; }
        public decimal ValorCofins { get; set; }


        public Servico(string descricao, double aliquotaIss, bool issRetidoFonte,
            string codigoServicoMunicipio, string itemListaServicoLC116,
            string cnae, string municipioPrestacaoServico, string codigoNbs,
            decimal valorPis, decimal valorCofins)
        {
            Descricao = descricao;
            AliquotaIss = aliquotaIss;
            IssRetidoFonte = issRetidoFonte;
            CodigoServicoMunicipio = codigoServicoMunicipio;
            ItemListaServicoLC116 = itemListaServicoLC116;
            Cnae = cnae;
            MunicipioPrestacaoServico = municipioPrestacaoServico;
            CodigoNbs = codigoNbs;
            ValorPis = valorPis;
            ValorCofins = valorCofins;
        }
    }
}
