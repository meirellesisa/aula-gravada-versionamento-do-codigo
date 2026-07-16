namespace ProjetoAulas.RecursosDoDotNet
{
    public class TrabalhandoComStrings
    {
        public static void ConverterParaLetrasMinusculas()
        {
            Console.WriteLine("Por favor digite alguma informação: ");
            var linha = Console.ReadLine();

            Console.WriteLine(linha.ToLower());
        }

        public static void ConverterParaLetrasMaiusculas()
        {
            Console.WriteLine("Por favor digite alguma informação: ");
            var linha = Console.ReadLine();

            Console.WriteLine(linha.ToUpper());
        }

        public static void AulaSubstring()
        {
            Console.WriteLine("Por favor digite alguma informação: ");
            var linha = Console.ReadLine();

            //Console.WriteLine(linha.Substring(0,8));
            //Console.WriteLine(linha.Substring(8));
            Console.WriteLine(linha.Substring(8,10));
        }

        public static void AulaRange()
        {
            var nomeArquivo = "2026_07_01_backup.bak";

            var ano = nomeArquivo[..4];
            Console.WriteLine(ano);

            var extensao = nomeArquivo[^3..];
            Console.WriteLine(extensao);

            var nome = nomeArquivo[11..^4];
            Console.WriteLine(nome);

            var apenasNome = nomeArquivo[..^4];
            Console.WriteLine(apenasNome);
        }

        public static void AulaContains()
        {
            var nomeArquivo = "2026_07_01_backup.bak";

            //Console.WriteLine($"Contém nome: {nomeArquivo.Contains("backup")}");
            Console.WriteLine($"Contém nome: {nomeArquivo.Contains("financeiro")}");

            if (nomeArquivo.Contains("financeiro"))
            {
                Console.WriteLine("Palavra encontrada");
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }
        }

        public static void AulaTrim()
        {
            var teste = "**ISABELLA MEIRELLES**";

            Console.WriteLine("TRIM: " + teste.Trim('*'));
            
            Console.WriteLine("INÍCIO: " + teste.TrimStart('*'));

            Console.WriteLine("FIM: " + teste.TrimEnd('*'));
        }

        public static void AulaStartsWithEndsWith()
        {
            var teste = "Curso Csharp";

            Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));

            //Console.WriteLine("FINAL: " + teste.EndsWith("Csharp02"));
            Console.WriteLine("FINAL: " + teste.EndsWith("Csharp"));
        }

        public static void AulaReplace()
        {
            var teste = "Curso Csharp";

            Console.WriteLine(teste);

            Console.WriteLine(teste.Replace("Csharp","C#"));
            Console.WriteLine(teste.Replace("Csharp",".Net"));
        }

        public static void AulaLengh()
        {
            Console.Write("Digite alguma informação: ");
            var teste = Console.ReadLine();

            Console.WriteLine(teste);
            Console.WriteLine(teste.Length);
        }
    }
}
