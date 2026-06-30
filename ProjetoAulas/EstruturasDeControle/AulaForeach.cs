namespace ProjetoAulas.EstruturasDeControle
{
    public class AulaForeach
    {
        public static void Executar()
        {
            var lista = new List<string>()
            {
                "Isabella",   // indice/posicao 0
                "Curso", // indice/posicao 1
                "Csharp"     // indice/posicao 2
            };


            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            foreach (var item in "Isabella Meirelles")
            {
                Console.WriteLine(item);
            }
        }
    }
}
