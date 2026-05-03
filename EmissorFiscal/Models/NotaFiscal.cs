
namespace EmissorFiscal.Models
{
    abstract class NotaFiscal
    {
        private static int _contador = 0;
        public int NumeroNota { get; set; }
        public static DateTime DataEmissao { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public abstract void EmitirNota();

        public NotaFiscal() { }
        public NotaFiscal(decimal valorTotal)
        {
            DataEmissao = DateTime.Now;
            NumeroNota = ++_contador;
            ValorTotal = valorTotal;
        }
    }
}
