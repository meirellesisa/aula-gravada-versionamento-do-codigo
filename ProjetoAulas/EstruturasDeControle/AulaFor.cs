namespace ProjetoAulas.EstruturasDeControle
{
    public class AulaFor
    {
        public static void Executar()
        {
            var lista = new List<string>()
            {
                "Isabella",   // indice 0
                "Meirelles", // indice 1
                "Curso"     // indice 2
            };

            var count = lista.Count;

            //inicialização ; condição ; incremento

            for (var i = 0; i < count; i++)
            {
                var nome = lista[i];
                Console.WriteLine(nome);
            }
            ;

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            // o incremento pode ser feito da seguinte forma:
            // i++ -> i = i + 1
            //  i -> i + 1
            //  i += 1

        }
    }
}
