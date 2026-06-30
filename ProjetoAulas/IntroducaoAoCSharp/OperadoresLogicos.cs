namespace ProjetoAulas.IntroducaoAoCSharp
{
    public class OperadoresLogicos
    {
        public static void Executar()
        {
            var numero1 = 1;
            var numero2 = 2;

            //Operador lógico AND -> && -> E
            // Ambas as expressões precisam ser verdadeiras para o resultado ser verdadeiro

            var valido = numero2 > numero1 && 8 > 7;
            Console.WriteLine(valido);

            var valido2 = numero2 > numero1 && 6 > 7;
            Console.WriteLine(valido2);

            //Operador lógico OR-> || -> OU
            // Basta com que uma das expressões seja verdadeira para o resultado ser verdadeiro

            var valido3 = numero2 > numero1 || 6 > 7;
            Console.WriteLine(valido3);

            var valido4 = numero2 > 10 || 6 > 7;
            Console.WriteLine(valido4);

            var valido5 = numero2 > numero1 || 8 > 7;
            Console.WriteLine(valido5);

            //Operador lógico Not -> ! -> Negação
            var valido6 = !(numero2 > 10);
            Console.WriteLine(valido6);

            var valido7 = !(numero2 > numero1);
            Console.WriteLine(valido7);
        }
    }
}
