namespace ProjetoAulas.IntroducaoAoCSharp
{
    public class OperadoresRelacionais
    {
        public static void Executar()
        {
            var numero1 = 1;
            var numero2 = 2;

            // Relacional de igualdade
            bool igual = numero1 == numero2;
            Console.WriteLine(igual);
            //var idade = 33;

            // Relacional maior que 
            bool maior = numero2 > numero1;
            Console.WriteLine(maior);

            // Relacional menor que
            bool menor = numero2 < numero1;
            Console.WriteLine(menor);

            // Relacional maior ou igual 
            bool maiorOuIgual = numero2 >= numero1;
            Console.WriteLine(maiorOuIgual);

            // Relacional menor ou igual
            bool menorOuIgual = numero2 <= numero1;
            Console.WriteLine(menorOuIgual);

            bool maiorOuIgual2 = 1 >= 1;
            Console.WriteLine(maiorOuIgual2);

            // Relacional diferente
            bool diferente = numero2 != numero1;
            Console.WriteLine(diferente);
        }
    }
}
