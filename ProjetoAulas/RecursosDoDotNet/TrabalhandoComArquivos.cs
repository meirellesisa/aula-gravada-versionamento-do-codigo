namespace ProjetoAulas.RecursosDoDotNet
{
    public class TrabalhandoComArquivos
    {
        public static void AulaCriandoArquivo()
        {
            using var escrever = new StreamWriter("C:\\CursoEstardandoDevs\\ProjetoAulas\\RecursosDoDotNet\\Cadastro.txt", true);

            Console.Write("Informar um nome: ");
            var nome = Console.ReadLine();
         
            escrever.WriteLine("ID....: " + Random.Shared.Next(1, 100));
            escrever.WriteLine("Nome..: " + nome);
            escrever.WriteLine("-----------------------------------------");
            
        }

        public static void AulaLendoArquivo()
        {
            //var conteudo = File.ReadAllText("C:\\CursoEstardandoDevs\\ProjetoAulas\\RecursosDoDotNet\\Cadastro.txt");
            //Console.WriteLine(conteudo);

            using var ler = new StreamReader("C:\\CursoEstardandoDevs\\ProjetoAulas\\RecursosDoDotNet\\Cadastro.txt");

            while (!ler.EndOfStream)
            {
                var linha = ler.ReadLine();
                Console.WriteLine(linha);
                Console.WriteLine("Ativo");
            }
        }

        public static void AulaExcluindoArquivo()
        {
            if (File.Exists("C:\\CursoEstardandoDevs\\ProjetoAulas\\RecursosDoDotNet\\Cadastro.txt"))
            {
                File.Delete("C:\\CursoEstardandoDevs\\ProjetoAulas\\RecursosDoDotNet\\Cadastro.txt");
            }
        }
    }
}
