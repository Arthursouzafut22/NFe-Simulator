namespace EmissorFiscal.Ui
{
    class MenuPrincipal
    {
        public void Menu()
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

            if (!int.TryParse(Console.ReadLine(), out int opcao))
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            switch (opcao)
            {
                case 1:
                    TelaNFSe telaNFSe = new TelaNFSe();
                    telaNFSe.Executar();
                    break;
                case 2:
                    //"Ainda vou implementar...";
                    break;
                case 3:
                    //"Ainda vou implementar...";
                    break;
                case 4:
                    //"Ainda vou implementar...";
                    break;
                case 5:
                    //"Ainda vou implementar...";
                    break;
            }
        }
    }
}
