namespace ProjetoAulas.IntroducaoAoCSharp
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            Console.WriteLine("Primeiro Projeto!");

            string nomePessoa = "Isabella Meirelles";

            nomePessoa = "Isabella Meirelles de Freitas";

            Console.WriteLine("Nome = " + nomePessoa);

            int idade = 25;

            Console.WriteLine("Idade = " + idade);

            decimal preco = 19.90m;
            Console.WriteLine("Preço = " + preco);

            float alturaPessoa = 1.75f;
            Console.WriteLine($"A altura é igual a : {alturaPessoa}");

            double peso = 70;
            Console.WriteLine($"O peso da pessoa é: {peso} Kg");

            // Inferência de tipo

            var idadeNova = 30;
            Console.WriteLine("Nova Idade = " + idade);

            char letra = 'A';
            Console.WriteLine(letra);

            bool ativo = true;
            //ativo = false;-

            Console.WriteLine(ativo);

            const string nomeCurso = "C# para Iniciantes";
            Console.WriteLine(nomeCurso);


            //var nomeCurso = "C# para Iniciantes - Atualizado";

            /*
             * Linha 1
             * Linha 2
             * Linha 3
            */

            // soma de dois números
            int resultado = 2 + 2;
            int rultadoDaSoma = 2 + 2;

            // regra de negocio: idade minima de cadastro é 18 anos

        }
    }
}
