namespace ProjetoAulas.IntroducaoAoCSharp
{
    public class OperadorTernario
    {
        public static void Executar()
        {          
            bool ativo = true;
            ativo = false;

            string status = ativo ? "Cadastro Ativo" : "Cadastro Inativo";
            Console.WriteLine(status);
        }
    }
}
