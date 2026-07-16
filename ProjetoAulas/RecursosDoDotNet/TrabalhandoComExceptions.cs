namespace ProjetoAulas.RecursosDoDotNet
{
    public class TrabalhandoComExceptions
    {
        public static void AulaGerandoExcecoes()
        {
            while (true)
            {
                Console.Write("Informe um número: ");

                var numero = Console.ReadLine();

                var resultado = 500 / int.Parse(numero);

                Console.WriteLine("Resultado " + resultado);

            }
        }

        public static void AulaTratandoExcecoes()
        {
            while (true)
            {
                try
                {
                    Console.Write("Informe um número: ");

                    var numero = Console.ReadLine();

                    var resultado = 500 / int.Parse(numero);

                    Console.WriteLine("Resultado " + resultado);

                }
                catch (DivideByZeroException exception)
                {
                    Console.WriteLine("Ocorreu um erro de divisão.");

                    Console.WriteLine(exception.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro. " + ex.Message);

                    Console.WriteLine("Stack: ");
                    Console.WriteLine(ex.StackTrace);
                }


            }
        }
    }
}
