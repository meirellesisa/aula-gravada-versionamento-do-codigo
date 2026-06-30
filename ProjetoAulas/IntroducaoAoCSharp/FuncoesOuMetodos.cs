namespace ProjetoAulas.IntroducaoAoCSharp
{
    public class FuncoesOuMetodos
    {
        public static void Executar()
        {
            string NomeCompleto()
            {
                var primeiroNome = "Isabella";
                var segundoNome = "Meirelles";

                return primeiroNome + " " + segundoNome;
            }


            int SomaValores(int a, int b)
            {
                return a + b;
            }

            //var resultado = EscreverNome();

            //EscreverNome();
            var nome = NomeCompleto();
            Console.WriteLine(nome);

            //Console.WriteLine(primeiroNome);

            void EscreverNome()
            {
                Console.WriteLine("Procedimento é uma função que retorna o tipo void (nenhum valor)");
                var nome = NomeCompleto();
                var soma = SomaValores(3, 6);

                Console.WriteLine(nome);
                Console.WriteLine(soma);
            }


            var soma1 = SomaValores(a: 100, b: 1530);
            Console.WriteLine(soma1);


            var soma2 = SomaValores(a: 10, b: 37);
            Console.WriteLine(soma2);


            var soma3 = SomaValores(23, 58);
            Console.WriteLine(soma3);

            string NomeEIdade(string nome, int idade)
            {
                return $"Meu nome é {nome} e tenho a seguinte idade: {idade}";
            }


            ////var nomeEIdade = NomeEIdade("Meu nome é Isabella e tenho a seguinte idade: ", 25);
            ////Console.WriteLine(nomeEIdade);
            ///
            var nomeEIdade2 = NomeEIdade("Isabella", 25);
            Console.WriteLine(nomeEIdade2);

            var nomeEIdade3 = NomeEIdade("João", 12);
            Console.WriteLine(nomeEIdade3);

            var nomeEIdade4 = NomeEIdade("Maria", 60);
            Console.WriteLine(nomeEIdade4);


        }
    }
}
