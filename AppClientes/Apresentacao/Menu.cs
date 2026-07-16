namespace AppClientes.Apresentacao
{
    public static class Menu
    {
        public static void Exibir()
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("         SISTEMA DE CLIENTES"          );
            Console.WriteLine("======================================");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Exibir clientes");
            Console.WriteLine("3 - Editar cliente");
            Console.WriteLine("4 - Excluir cliente");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("======================================");

        }
    }
}
