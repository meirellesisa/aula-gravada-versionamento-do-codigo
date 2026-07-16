namespace ProjetoAulas.ClassesEOutrosTipos.Heranca
{
    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }

        public void ImprimirMatricula()
        {
            Console.WriteLine($"Matrícula: {Matricula}");
        }

        public static void ExemploHerancao02()
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
