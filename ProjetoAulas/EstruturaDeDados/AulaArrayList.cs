using System.Collections;

namespace ProjetoAulas.EstruturaDeDados
{
    public class AulaArrayList
    {
        public static void Executar()
        {
            var arrayList = new ArrayList();

            // Adicionando dados 
            arrayList.Add(1);          // indice 0
            arrayList.Add("Isabella"); // indice 1
            arrayList.Add(true);       // indice 2

            // Removendo item da nossa coleção ArrayList

            arrayList.RemoveAt(1);

            //arrayList = new ArrayList();
            //arrayList.Clear();

            // Forma de ler os dados 
            //Console.WriteLine(arrayList[1]);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
