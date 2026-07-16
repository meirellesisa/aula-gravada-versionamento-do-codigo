namespace ProjetoAulas.ClassesEOutrosTipos.Heranca
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine($"CPF: {CPF}");
        }


        public static void ExemploHerancao01()
        {
            var pessoaFisica = new PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Rua A, 123";
            pessoaFisica.Cidade = "Rio de Janeiro";
            pessoaFisica.Cep = "12345-678";
            pessoaFisica.CPF = "123.456.789-00";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
        }
    }
}
