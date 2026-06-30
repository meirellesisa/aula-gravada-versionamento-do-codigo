namespace ProjetoAulas.EstruturaDeDados
{
    public class AulaPilha
    {
        public static void Executar()
        {
            var stack = new Stack<string>();

            stack.Push("Isabella");
            stack.Push("Meirelles");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            var nome3 = stack.Peek();
            Console.WriteLine(nome3);
            var nome = stack.Pop();
            var nome2 = stack.Pop();
            //Console.WriteLine(nome);
            //Console.WriteLine(nome2);
        }
    }
}
