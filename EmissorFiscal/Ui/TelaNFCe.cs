using EmissorFiscal.Models;

namespace EmissorFiscal.Ui
{
     class TelaNFCe
    {
        public void Executar()
        {

            TelaCliente telaCliente = new TelaCliente();
            telaCliente.ColetarDadosCliente();

            Console.WriteLine("");
            Console.Write("Digite a quantidades de produtos: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantidadeProdutos; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"...Digite o {i} produto... ");
                Console.WriteLine("");
                Console.Write("Digite o nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Digite a descrição do produto: ");
                string descricao = Console.ReadLine();
                Console.Write("Digite o codigo do produto: ");
                string codigoProduto = Console.ReadLine();
                Console.Write("Digite o codigo de barras: ");
                string codigoDeBarras = Console.ReadLine();
                Console.Write("Digite o NCM do produto: ");
                string ncm = Console.ReadLine();
                Console.Write("Digite o preço unitario do produto: ");
                decimal precoUnitario = decimal.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de produto: ");
                int quantidade = int.Parse(Console.ReadLine());


                Produto produto = new Produto(
                    nomeProduto,
                    descricao, 
                    codigoProduto,
                    codigoDeBarras,
                    ncm,
                    precoUnitario,
                    quantidade);

                NFC_e nfce = new NFC_e();

                nfce.AdicionarProdutos(produto);
            }
        }
    }
}
