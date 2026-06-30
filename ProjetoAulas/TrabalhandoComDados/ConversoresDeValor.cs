namespace ProjetoAulas.TrabalhandoComDados
{
    public class ConversoresDeValor
    {
        public static void Executar()
        {
            // string -> int 
            // string -> bool
            // string -> double 

            //int numero = int.Parse("a");
            //int numero = Convert.ToInt32("a");
            //int numero = Convert.ToInt32(null);
            //int numero = int.Parse(null);
            int numero = int.Parse("1");
            Console.WriteLine(numero);


            //bool verdadeiro = bool.Parse("true");
            //bool verdadeiro = bool.Parse("verdadeiro");
            //Console.WriteLine(verdadeiro);

            //var numero = "12345";
            var numero1 = "abc";

            //var tryParse = int.TryParse(numero, out int numeroConvertido) 
            //             ? $"Número convertido com sucesso - {numeroConvertido}"
            //             : $"Não foi possível converter - {numero}";

            //var tryParse = int.TryParse(numero, out int numeroConvertido)
            //             ? $"Número convertido com sucesso - {numeroConvertido}"
            //             : $"Não foi possível converter - {numero} - {numeroConvertido}";

            //Console.WriteLine(tryParse);

            int numeroConvertido;
            var tryParse = int.TryParse(numero1, out numeroConvertido)
                         ? $"Número convertido com sucesso - {numeroConvertido}"
                         : $"Não foi possível converter - {numero} - {numeroConvertido}";
            var soma = numeroConvertido + 100;
            Console.WriteLine(tryParse);
            Console.WriteLine(soma);

            // Parse VS TryParse
            // Parse -> Lança uma exceção caso a conversão falhe
            // TryParse -> Retorna um booleano indicando se a conversão
            // foi bem-sucedida ou não, sem lançar uma exceção.
            // O valor convertido é retornado por meio de um parâmetro de saída (out).

            //bool.TryParse();
            //long.TryParse();
            //char.TryParse();
            //double.TryParse();


        }
    }
}
