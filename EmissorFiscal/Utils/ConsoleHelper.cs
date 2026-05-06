using EmissorFiscal.Models;

namespace EmissorFiscal.Utils
{
    class ConsoleHelper
    {
        public void ConfirmarEmissao(NotaFiscal nota)
        {
            Console.Write("");
            Console.Write("Dessa realizar a emissão? (S/N) ");
            char confirmacao = char.Parse(Console.ReadLine());

            switch (confirmacao)
            {
                case 'S':
                    nota.EmitirNota();
                    break;
                case 'N':
                    Console.ReadKey();
                    break;
            }

        }
    }
}
