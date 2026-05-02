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

            int opcao = int.Parse(Console.ReadLine());
        }
    }
}
