namespace ProjetoAulas.EstruturaDeDados
{
    public class AulaListaGenerica
    {
        public static void Executar()
        {
            var lista = new List<string>(10);

            lista.Add("Isabella");  // indice 0
            lista.Add("Meirelles"); // indice 1

            var nome = lista[0];
            // Console.WriteLine(nome);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            var lista2 = new List<string>(10) { "Isabella", "Meirelles", "Curso" };
            var nome2 = lista2[1];

            lista2.RemoveAt(2);

            //Console.WriteLine(nome2);
            foreach (var item in lista2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
