
namespace EmissorFiscal.Models
{
    abstract class NotaFiscal
    {

        public int NumeroNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public abstract void EmitirNota();

        public NotaFiscal() { }
        public NotaFiscal(DateTime dataEmissao)
        {
            DataEmissao = DateTime.Now;
        }

    }
}
