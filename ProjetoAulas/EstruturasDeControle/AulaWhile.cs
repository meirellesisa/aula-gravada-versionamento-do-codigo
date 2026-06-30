namespace ProjetoAulas.EstruturasDeControle
{
    public class AulaWhile
    {
        public static void Executar()
        {
            var i = 3;

            while (i < 2)
            {
                Console.WriteLine("var i = " + i);
                i++;
                //i = i + 1;
                //i += 1;
            }


            var j = 3;

            do
            {
                Console.WriteLine("var j = " + j);
                j++;
            }
            while (j < 2);

            var opcaoValida = false;
            do
            {
                Console.WriteLine("Menu do sistema");
            }
            while (opcaoValida);

            i = 0;

            while (i < 5)
            {
                Console.WriteLine("var i = " + i);
                i++;

                if (i == 2)
                {
                    Console.WriteLine("Valor de i é igual a 2");
                    break;
                }
            }

            while (i < 5)
            {

                if (i < 2)
                {
                    Console.WriteLine("Continuando ...");

                    i++;
                    continue;
                }

                Console.WriteLine("var i = " + i);
                i++;
            }
        }
    }
}
