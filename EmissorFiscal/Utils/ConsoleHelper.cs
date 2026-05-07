using EmissorFiscal.Models;
using EmissorFiscal.Ui;

namespace EmissorFiscal.Utils
{
    class ConsoleHelper
    {
        public static void ConfirmarEmissao(NotaFiscal nota)
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
                    MenuPrincipal.Start();
                    break;
                default:
                    MenuPrincipal.Start();
                    break;
            }
        }
    }
}
