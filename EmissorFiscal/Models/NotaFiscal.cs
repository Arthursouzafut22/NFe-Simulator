
namespace EmissorFiscal.Models
{
    abstract class NotaFiscal
    {
        private static int _contador = 0;
        public int NumeroNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public NotaFiscal() { }
        public NotaFiscal(decimal valorTotal)
        {
            DataEmissao = DateTime.Now;
            NumeroNota = ++_contador;
            ValorTotal = valorTotal;
        }
        public abstract void EmitirNota();
    }
}
