using EmissorFiscal.Enums;

namespace EmissorFiscal.Models
{
    internal class NFC_e : NotaFiscal
    {

        public Guid Id { get; }
        public TipoNota Tipo { get; set; }

        public List<Produto> produtos = new List<Produto>();

        public NFC_e()
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
            return base.ToString();
        }
    }
}
