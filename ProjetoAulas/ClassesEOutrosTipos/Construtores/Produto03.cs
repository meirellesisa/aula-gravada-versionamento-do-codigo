namespace ProjetoAulas.ClassesEOutrosTipos.Construtores
{
    public class Produto03
    {
        public string Descricao { get; set; }

        public Produto03() { }

        //public Produto03()
        //{
        //    Console.WriteLine("Construtor padrão chamado.");
        //    Console.WriteLine("Objeto criado");

        //    Descricao = "Mouse";
        //}

        public Produto03(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
            {
                Console.WriteLine("Descrição inválida");
                return;
            }
            Console.WriteLine("Construtor com parâmetro chamado.");
            Descricao = descricao;
        }

        public static void ExemploConstrutores()
        {
            Produto03 produto1 = new Produto03();
            Console.WriteLine($"Produto 1: {produto1.Descricao}");

            Produto03 produto2 = new Produto03("Teclado");
            Console.WriteLine($"Produto 2: {produto2.Descricao}");
        }
    }
}
