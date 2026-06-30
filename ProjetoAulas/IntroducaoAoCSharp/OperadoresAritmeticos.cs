namespace ProjetoAulas.IntroducaoAoCSharp
{
    public class OperadoresAritmeticos
    {
        public static void Executar()
        {

            var numero1 = 1;
            var numero2 = 2;

            //int soma = numero1 + numero2;
            var soma = numero1 + numero2;
            Console.WriteLine("Soma = " + soma);

            var subtracao = numero2 - numero1;
            Console.WriteLine($"Subtração = {subtracao}");

            var multiplicacao = numero1 * numero2;
            Console.WriteLine($"Multiplicação = {multiplicacao}");

            var divisao = numero2 / numero1;
            Console.WriteLine($"Divisão = {divisao}");

            var multiplicacao2 = (numero1 * numero2) * 10;
            Console.WriteLine($"Mais de uma opercação matemática = {multiplicacao2}");

        }
    }
}
