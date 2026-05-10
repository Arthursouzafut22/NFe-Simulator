using EmissorFiscal.Enums;
using EmissorFiscal.Repositories;
using EmissorFiscal.Utils;

namespace EmissorFiscal.Ui
{
    class TelaListaNotas
    {
        public static void StartMenuListagem()
        {
            MenuListagemNotas();
            var opcao = Validador.ValidarMenu();

            switch (opcao)
            {
                case 1:
                    NotaRepository.ListarNotaPorTipo(TipoNota.NFS_e);
                    break;

                case 2:
                    NotaRepository.ListarNotaPorTipo(TipoNota.NFC_e);
                    break;

                case 3:
                    NotaRepository.ListarNotasEmitidas();
                    break;
                case 4:
                    MenuPrincipal.Start();
                    break;

                default:
                    MenuPrincipal.Start();
                    break;
            }
        }

        public static void MenuListagemNotas()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║        LISTAGEM DE NOTAS         ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║ [1] Listar NFS-e                 ║");
            Console.WriteLine("║ [2] Listar NFC-e                 ║");
            Console.WriteLine("║ [3] Listar todas                 ║");
            Console.WriteLine("║ [4] Voltar                       ║");
            Console.WriteLine("╚══════════════════════════════════╝");
        }
    }
}