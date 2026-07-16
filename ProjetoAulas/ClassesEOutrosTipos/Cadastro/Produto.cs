namespace ProjetoAulas.ClassesEOutrosTipos.Cadastro
{

    // Classe -> é um modelo para representar um objeto no mundo real.
    // Objeto -> é uma instancia de uma classe cria com o new.
    // Propriedade -> guarda informações sobre o objeto.
    // Método -> executa a ação que o objeto.
    // Publico -> pode ser acessado de qualquer lugar da nossa aplicação.
    // Privado -> só pode ser acessado dentro da própria classe.
    // Classe estática -> não precisa ser instanciada,
    // só pode ser acessada diretamente pelo nome da classe.

    public class Produto
    {
        private int Id;
        public string Descricao { get; set; }

        public int Estoque { get; }
        //public readonly int Estoque;

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public static void Executar()
        {
            var produto = new Produto
            {
                Descricao = "Teclado"
            };
            produto.SetId(1);

            Console.WriteLine(produto.GetId());
            produto.ImprimirDescricao();
        }

        public static void PropriedadeSomenteLeitura()
        {
            Console.WriteLine("Hello, World!");

            var produto = new Produto();
            produto.Descricao = "Mouse";
            //produto.Estoque = 10;
            Console.WriteLine(produto.Estoque);
        }
    }

    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }


        public static void Executar()
        {
            var resultado = SomarNumeros(2, 3);
            Console.WriteLine($"Resultado da soma: {resultado}");
        }
    }
}
