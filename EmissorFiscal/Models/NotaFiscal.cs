
namespace EmissorFiscal.Models
{
    abstract class NotaFiscal
    {

        public int NumeroNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public Cliente Cliente { get; set; }
        public double ValorTotal { get; set; }
        public abstract void EmitirNota();
    }
}
