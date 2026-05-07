using EmissorFiscal.Utils;

namespace EmissorFiscal.Ui
{
    class MenuPrincipal
    {
        public static void Start()
        {
            Menu();
            var opcao = Validador.ValidarMenu();

            switch (opcao)
            {
                case 1:
                    TelaNFSe telaNFSe = new TelaNFSe();
                    telaNFSe.Executar();
                    break;

                case 2:
                    TelaNFCe telaNFCe = new TelaNFCe();
                    telaNFCe.Executar();
                    break;

                case 3:
                    // .........";
                    break;

                case 4:
                    // ".......";
                    break;

                default:
                    Menu();
                    break;
            }
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║        EMISSOR FISCAL - v1.0     ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║ [1] Emitir NFS-e                ║");
            Console.WriteLine("║ [2] Emitir NFC-e                ║");
            Console.WriteLine("║ [3] Emitir NF-e                 ║");
            Console.WriteLine("║ [4] Listar notas emitidas       ║");
            Console.WriteLine("║ [5] Sair                        ║");
            Console.WriteLine("╚══════════════════════════════════╝");
        }
    }
}
