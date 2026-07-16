namespace ProjetoAulas.ClassesEOutrosTipos.ClasseSelada
{
    public sealed class Configuracao
    {
        public string Host { get; set; }


        public static void ExemploClasseSelada()
        {

            //var configuracao = new Configuracao();
            //configuracao.Host = "localhost";

            var configuracao = new Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);


        }
    }
}
