using EmissorFiscal.Enums;
using EmissorFiscal.Models;
using System.Text;


namespace EmissorFiscal.Repositories
{
    class NotaRepository
    {
        public static List<NotaFiscal> NotasEmitidas = new List<NotaFiscal>();

        public static void AdicionarNotas(NotaFiscal nota)
        {
            NotasEmitidas.Add(nota);
        }

        public static void ListarNotasEmitidas()
        {

            if (NotasEmitidas.Count == 0)
            {
                Console.WriteLine("Nenhuma nota emitida ainda...");
                return;
            }

            foreach (NotaFiscal nota in NotasEmitidas)
            {
                Console.WriteLine(nota);
            }

        }

        public static void ListarNotaPorTipo(TipoNota tipo)
        {
            var notasTipo = NotasEmitidas.Where(nota => nota.TipoNota == tipo);

            if (notasTipo.Count() == 0)
            {
                Console.WriteLine("Nenhuma nota emitida ainda...");
                return;
            }

            foreach (NotaFiscal n in notasTipo)
            {
                Console.WriteLine(n);
            }
        }
    }
}
