using EmissorFiscal.Enums;
using EmissorFiscal.Models;
using EmissorFiscal.Repositories;
using EmissorFiscal.Utils;

namespace EmissorFiscal.Ui
{
     class TelaNFCe
    {
      public  NFCe NFCe { get; set; }
      public Produto Produto { get; set; }
        public void Executar()
        {
            NFCe nota = new NFCe(TipoNota.NFC_e);

            TelaCliente telaCliente = new TelaCliente();
            telaCliente.ColetarDadosCliente();

            nota.Cliente = telaCliente.Cliente;

            Console.WriteLine("");
            Console.Write("Digite a quantidades de produtos: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantidadeProdutos; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"...Digite o {i} produto... ");
                Console.WriteLine("");
                Console.Write("Digite o nome do produto: ");
                string nomeProduto = Validador.LerCampoObrigatorio();
                Console.Write("Digite a descrição do produto: ");
                string descricao = Validador.LerCampoObrigatorio();
                Console.Write("Digite o codigo do produto: ");
                string codigoProduto = Validador.LerCampoObrigatorio();
                Console.Write("Digite o codigo de barras: ");
                string codigoDeBarras = Validador.LerCampoObrigatorio();
                Console.Write("Digite o NCM do produto: ");
                string ncm = Validador.LerCampoObrigatorio();
                Console.Write("Digite o preço unitario do produto: ");
                decimal precoUnitario = decimal.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de produto: ");
                int quantidade = int.Parse(Console.ReadLine());


                Produto = new Produto(
                    nomeProduto,
                    descricao, 
                    codigoProduto,
                    codigoDeBarras,
                    ncm,
                    precoUnitario,
                    quantidade);

                nota.AdicionarProdutos(Produto);
            }

            ConsoleHelper.ConfirmarEmissao(nota);
            NotaRepository.AdicionarNotas(nota);
        }
    }
}
