namespace ProjetoAulas.EstruturaDeDados
{
    public class AulaFila
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Isabella"); // primeiro pessoa da fila 
            fila.Enqueue("Meirelles"); //segunda pessoa da fila 
                                       // fim da fila

            //foreach(var item in fila)
            //{
            //    Console.WriteLine(item);
            //}

            //var nome = fila.Peek();
            //var nome2 = fila.Peek();
            //Console.WriteLine(nome);
            //Console.WriteLine(nome2);

            var nome = fila.Dequeue();
            Console.WriteLine(nome);

            var nome2 = fila.Dequeue();
            Console.WriteLine(nome2);
        }
    }
}
