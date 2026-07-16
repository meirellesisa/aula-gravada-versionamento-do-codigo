using AppClientes.Apresentacao;
using AppClientes.Interfaces;

namespace AppClientes.Aplicacao
{
    public class AppClientesAplicacao
    {
        private readonly IClienteRespositorio _clienteRepositorio;

        public AppClientesAplicacao(IClienteRespositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void Executar()
        {
            var executando = true;

            while (executando)
            {
                Menu.Exibir();

                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        _clienteRepositorio.Cadastrar();
                        break;

                    case "2":
                        _clienteRepositorio.Exibir();
                        break;

                    case "3":
                        _clienteRepositorio.Editar();
                        break;

                    case "4":
                        _clienteRepositorio.Excluir();        
                        break;

                    case "5":
                        _clienteRepositorio.SalvarDados();
                        executando = false;
                        break;

                    default:
                        ExibirOpçãoInvalida();
                        break;
                }
            }
        }

        private void ExibirOpçãoInvalida()
        {
            Console.Clear();
            Console.WriteLine("Opção inválida.");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
