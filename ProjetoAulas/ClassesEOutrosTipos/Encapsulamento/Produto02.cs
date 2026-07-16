namespace ProjetoAulas.ClassesEOutrosTipos.Encapsulamento
{
    public class Produto02
    {
        public int Id { get; private set; }
        public string Descricao { get; set; }
        private decimal Preco { get; set; }

        public void SetPreco(decimal novoPreco)
        {
            if (novoPreco < 0)
            {
                Console.WriteLine("Preco inválido");
                return;
            }

            Preco = novoPreco;
        }

        public void SetId(int novoId)
        {
            if (novoId < 0)
            {
                Console.WriteLine("Id inválido");
                return;
            }

            Id = novoId;
        }

        public decimal GetPreco()
        {
            return Preco;
        }

        public static void ExemploEncapsulamento()
        {
            var produto = new Produto02();

            produto.Descricao = "Mouse";
            // produto.Preco = -500;
            produto.SetPreco(150);

            Console.WriteLine(produto.GetPreco());
            //produto.Id = 32;
            produto.SetId(32);

            Console.WriteLine(produto.Id);

        }
    }
}
