using EmissorFiscal.Utils;

namespace EmissorFiscal.Ui
{
    class MenuPrincipal
    {

        public void Start()

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
                    //"Ainda vou implementar...";
                    break;
                case 4:
                    //"Ainda vou implementar...";
                    break;
                default:
                    Menu();
                    break;
            }
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║        EMISSOR FISCAL - v1.0     ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            Console.WriteLine("║ [1] Emitir NFS-e                ║");
            Console.WriteLine("║ [2] Emitir NFC-e                ║");
            Console.WriteLine("║ [3] Listar notas emitidas       ║");
            Console.WriteLine("║ [4] Sair                        ║");
            Console.WriteLine("╚══════════════════════════════════╝");

            //if (!int.TryParse(Console.ReadLine(), out int opcao))
            //{
            //    Console.WriteLine("Opção inválida!");
            //    return;
            //}

            //var opcao = Validador.ValidarMenu();
            //switch (opcao)
            //{
            //    case 1:
            //        TelaNFSe telaNFSe = new TelaNFSe();
            //        telaNFSe.Executar();
            //        break;
            //    case 2:
            //        TelaNFCe telaNFCe = new TelaNFCe();
            //        telaNFCe.Executar();
            //        break;
            //    case 3:
            //        //"Ainda vou implementar...";
            //        break;
            //    case 4:
            //        //"Ainda vou implementar...";
            //        break;
            //    default:
            //        Menu();
            //        break;
            //}




        }
    }
}
