namespace AppClientes.Interfaces
{
    public interface IClienteRespositorio
    {
        void Cadastrar();
        void Exibir();
        void Editar();
        void Excluir();
        void SalvarDados();
        void CarregarDados();
    }
}
