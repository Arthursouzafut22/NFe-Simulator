using static System.Net.Mime.MediaTypeNames;

namespace EmissorFiscal.Utils
{
    class Validador
    {
        public static string LerCampoObrigatorio()
        {
            string valor;

            do
            {
                valor = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(valor))
                {
                    Console.WriteLine("Valor inválido, preencha o campo:");
                }
            } while (string.IsNullOrWhiteSpace(valor));

            return valor;
        }

        public static string ValidarEmail()
        {
            string email = LerCampoObrigatorio();

            while (!email.EndsWith("@gmail.com") && !email.EndsWith("@hotmail.com"))
            {
                Console.WriteLine("E-mail inválido! Use @gmail.com ou @hotmail.com");
                Console.Write("Digite novamente: ");
                email = LerCampoObrigatorio();
            }

            return email;
        }

        public static int ValidarMenu()
        {
            int num;



            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out num) && (num == 1 || num == 2 || num == 3 || num == 4))
                {
                    return num;
                }
                Console.WriteLine("Opção inválida, digite 1, 2, 3 ou 4:");
            }





        }

    }
}
