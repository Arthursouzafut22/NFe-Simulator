using EmissorFiscal.Models;
using EmissorFiscal.Utils;

namespace EmissorFiscal.Ui
{
    internal class TelaNFSe
    {
        public Servico Servico { get; set; }
        public NFSe NFSe { get; set; }

        public void Executar()
        {
            TelaCliente telaCliente = new TelaCliente();
            telaCliente.ColetarDadosCliente();

            Console.WriteLine("");
            Console.WriteLine("...Dados da atividade prestada...");

            Console.Write("Digite a descrição do serviço: ");
            string descricao = Validador.LerCampoObrigatorio();

            Console.Write("Digite a alíquota de ISS sobre o serviço: ");
            double aliquotaIss = double.Parse(Console.ReadLine());

            Console.Write("ISS retido na fonte? (S/N): ");
            char valorIssRetido = char.Parse(Console.ReadLine().ToUpper());

            bool issRetidoFonte = valorIssRetido == 'S';

            Console.Write("Digite o código de tributação: ");
            string codigoServicoMunicipio = Validador.LerCampoObrigatorio(); ;

            Console.Write("Digite o item da lista de serviços (LC 116): ");
            string itemListaServicoLC116 = Validador.LerCampoObrigatorio();

            Console.Write("Digite o CNAE: ");
            string cnae = Validador.LerCampoObrigatorio();

            Console.Write("Digite o código NBS: ");
            string codigoNbs = Validador.LerCampoObrigatorio();

            Console.Write("Digite o município de prestação do serviço: ");
            string municipioPrestacaoServico = Validador.LerCampoObrigatorio();

            Console.Write("Digite o valor do PIS: ");
            decimal valorPis = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor do COFINS: ");
            decimal valorConfins = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor da prestação do serviço: ");
            decimal valorTotal = decimal.Parse(Console.ReadLine());

            Console.Write("");

            Servico = new Servico(
                descricao,
                aliquotaIss,
                issRetidoFonte,
                codigoServicoMunicipio,
                itemListaServicoLC116,
                cnae,
                codigoNbs,
                municipioPrestacaoServico,
                valorPis,
                valorConfins
            );

            NFSe nota = new NFSe(valorTotal);
            nota.Cliente = telaCliente.Cliente;
            nota.Servico = Servico;

            //ConsoleHelper console = new ConsoleHelper();
            ConsoleHelper.ConfirmarEmissao(nota);
        }
    }
}