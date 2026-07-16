namespace ProjetoAulas.ClassesEOutrosTipos.Heranca
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade {  get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Endereco: {Endereco}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Cep: {Cep}");
        }
    }
}
