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
    }
}
