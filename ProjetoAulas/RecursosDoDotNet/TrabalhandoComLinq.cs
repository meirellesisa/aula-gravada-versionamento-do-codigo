namespace ProjetoAulas.RecursosDoDotNet
{
    public class TrabalhandoComLinq
    {
        public static void AulaWhere()
        {
            var nomeCompleto = "ISABELLA MEIRELLES";

            Func<char, bool> filtro = c => c == 'A';

            var resultado1 = nomeCompleto.Where(filtro);
            var resultado2 = nomeCompleto.Where(c => c == 'E');

            foreach (var letra in resultado1)
            {
                Console.WriteLine(letra);
            }


            foreach (var letra in resultado2)
            {
                Console.WriteLine(letra);
            }

            var resultado3 =
                from c in nomeCompleto
                where c == 'L'
                select c;

            foreach (var letra in resultado3)
            {
                Console.WriteLine(letra);
            }

            int[] numeros = { 2, 5, 8, 10, 15, 20, 30 };

            var resultado4 = numeros.Where(n => n >= 10);

            foreach (var numero in resultado4)
            {
                Console.WriteLine(numero);
            }


            var pessoas = new List<Pessoa>()
            {
                new Pessoa("Isabella", 25),
                new Pessoa("João", 17),
                new Pessoa("Maria", 31),
                new Pessoa("Carlos", 15),
            };

            var maioresIdade = pessoas.Where(p => p.Idade >= 18);

            foreach (var pessoa in maioresIdade)
            {
                Console.WriteLine(pessoa.Nome);
            }
        }

        public static void AulaOrdenacao()
        {
            int[] numeros = { 15, 8, 30, 2, 18, 5, 10 };

            //var resultado = numeros.OrderBy(n => n);
            var resultado = numeros.OrderByDescending(n => n);

            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }

            var nomes = new List<string>()
            {
                "Rafael",
                "Eduardo",
                "Carlos",
                "Amanda",
                "Bruno"
            };

            //var resultado2 = nomes.OrderBy(n => n);
            var resultado2 = nomes.OrderByDescending(n => n);

            foreach (var nome in resultado2)
            {
                Console.WriteLine(nome);
            }

            var produtos = new List<Produto>()
            {
                new Produto("Notebook",4500),
                new Produto("Mouse",120),
                new Produto("Monitor",1800),
                new Produto("Teclado",250)
            };

            var resultado3 = produtos.OrderBy(p => p.Preco);

            foreach (var produto in resultado3)
            {
                Console.WriteLine(produto.Nome + "-" + produto.Preco);
            }

            var resultado4 = produtos.OrderBy(p => p.Nome);

            foreach (var produto in resultado4)
            {
                Console.WriteLine(produto.Nome);
            }
        }
        public static void AulaTake()
        {
            int[] numeros = { 15, 8, 30, 2, 18, 5, 10 };

            //var resultado = numeros
            //    .Take(3)
            //    .OrderBy(n => n);

            var resultado = numeros
                .Where(n => n > 10)
                .Take(10)
                .OrderBy(n => n);

            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }

            var produtos = new List<Produto>()
            {
                new Produto("Notebook",4500, true),
                new Produto("Mouse",120, false),
                new Produto("Monitor",1800, true),
                new Produto("Teclado",250, false)
            };

            var resultado2 = produtos
                .Where(p => p.Ativo)
                .OrderBy(p => p.Nome)
                .Take(2);

            foreach (var produto in resultado2)
            {
                Console.WriteLine(produto.Nome + "-" + produto.Preco + "-" + produto.Ativo);
            }
        }

        public static void AulaCount()
        {
            int[] numeros = { 15, 8, 30, 2, 18, 5, 10 };

            //var resultado = numeros.Count();

            var resultado = numeros.Count(n => n > 10);

            Console.WriteLine(resultado);
           
        }

        public static void AulaFirstFirstOrDefault()
        {
            int[] numeros = { 15, 8, 30, 2, 18, 5, 10 };

            //var resultado = numeros.First();

            //var resultado = numeros.First(n => n > 100);
            var resultado = numeros.FirstOrDefault(n => n > 100, -1);

            Console.WriteLine(resultado);

            int[] numeros2 = [];

            //var resultado3 = numeros2.First();
            //var resultado3 = numeros2.FirstOrDefault();

        }

























    }
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public bool Ativo { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, decimal preco, bool ativo)
        {
            Nome = nome;
            Preco = preco;
            Ativo = ativo;
        }
    }

}
