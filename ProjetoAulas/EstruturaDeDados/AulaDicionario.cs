namespace ProjetoAulas.EstruturaDeDados
{
    public class AulaDicionario
    {
        public static void Executar()
        {
            var dicionario = new Dictionary<int, string>();

            dicionario.Add(1, "Isabella");
            dicionario.Add(100, "Lucas");

            dicionario[50] = "Curso";

            var nome = dicionario[1];
            var nome2 = dicionario[100];
            var nome3 = dicionario[50];
            Console.WriteLine(nome3);

            var dicionario2 = new Dictionary<int, string>()
            {
                {1, "Isabella" },
                {100, "Lucas" },
                {50, "Curso" }
            };

            foreach (var item in dicionario2)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine();

            foreach (var item in dicionario2)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();

            foreach (var item in dicionario2)
            {
                Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
            }
        }
    }
}
