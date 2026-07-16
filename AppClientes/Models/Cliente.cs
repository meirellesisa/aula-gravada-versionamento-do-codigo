namespace AppClientes.Models
{
    public class Cliente
    {

        public int Id { get; private set; }

        public string Nome { get; private set; } = string.Empty;

        public DateOnly DataNascimento { get; private set; }

        public DateTime CadastradoEm { get; private set; }

        public decimal Desconto { get; private set; }

        public Cliente(
            int id,
            string nome,
            DateOnly dataNascimento,
            DateTime cadastradoEm)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            CadastradoEm = cadastradoEm;
            Desconto = 25;
        }


        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }
        public void AtualizarDataNascimento(DateOnly dataNacimento)
        {
            DataNascimento = dataNacimento;
        }

    }
}
