namespace ProjetoAulas.ClassesEOutrosTipos.Abstracao
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Informações: {GetInformacoes()}");
        }
    }
}
