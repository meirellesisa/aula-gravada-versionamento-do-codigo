using AppClientes.Interfaces;
using AppClientes.Models;
using System.Text.Json;

namespace AppClientes.Repositorios
{
    public class ClienteRepositorio : IClienteRespositorio
    {
        private const string NomeArquivo = "clientes.json";

        private static readonly JsonSerializerOptions OpcoesJson = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        private readonly List<Cliente> _clientes = [];

        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("CADASTRO DE CLIENTE");
            Console.WriteLine();

            var nome = LerNome();
            var dataNascimento = LerDataNacimento();

            var cliente = new Cliente(GerarProximoId(), nome, dataNascimento, DateTime.Now);

            _clientes.Add(cliente);
            SalvarDados();

            Console.WriteLine();
            Console.WriteLine("Cliente cadastrado com sucesso.");
            Console.WriteLine();

            ImprimirCliente(cliente);
            AguardarContinuacao();
        }

        public void Editar()
        {
            Console.Clear();
            Console.WriteLine("EDIÇÃO DE CLIENTE");
            Console.WriteLine();

            if (_clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                AguardarContinuacao();
                return;
            }

            var id = LerCodigoCliente();
            var cliente = BuscarPorId(id);

            if (cliente is null)
            {
                Console.WriteLine();
                Console.WriteLine("Cliente não encontrado.");
                AguardarContinuacao();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Cliente encontrado: ");
            Console.WriteLine();

            ImprimirCliente(cliente);

            Console.WriteLine();
            Console.WriteLine("Informe os novos dados.");
            Console.WriteLine();

            cliente.AtualizarNome(LerNome());
            cliente.AtualizarDataNascimento(LerDataNacimento());
            SalvarDados();

            Console.WriteLine();
            Console.WriteLine("Cliente alterado com sucesso.");
            Console.WriteLine();

            ImprimirCliente(cliente);
            AguardarContinuacao();
        }

        public void Excluir()
        {
            Console.Clear();
            Console.WriteLine("EXCLUSÃO DE CLIENTE");
            Console.WriteLine();

            if (_clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                AguardarContinuacao();
                return;
            }

            var id = LerCodigoCliente();
            var cliente = BuscarPorId(id);

            if (cliente is null)
            {
                Console.WriteLine();
                Console.WriteLine("Cliente não encontrado.");
                AguardarContinuacao();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Cliente encontrado: ");
            Console.WriteLine();

            ImprimirCliente(cliente);

            Console.WriteLine();
            Console.Write("Confirmar a exclusão? (S/N): ");

            var confirmacao = Console.ReadLine()?.Trim();

            if (!string.Equals(confirmacao, "S", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine("Exclusão cancelada.");
                AguardarContinuacao();

                return;
            }

            _clientes.Remove(cliente);
            SalvarDados();

            Console.WriteLine();
            Console.WriteLine("Cliente excluido com sucesso.");
            AguardarContinuacao();
        }

        public void Exibir()
        {
            Console.Clear();
            Console.WriteLine("CLIENTES CADASTRADOS");
            Console.WriteLine();

            if (_clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                AguardarContinuacao();
                return;
            }

            foreach (var cliente in _clientes)
            {
                ImprimirCliente(cliente);
            }

            AguardarContinuacao();
        }


        private int GerarProximoId()
        {
            if (_clientes.Count == 0)
            {
                return 1;
            }

            var resultado = _clientes.Max(cliente => cliente.Id) + 1;

            return resultado;
        }
        private static string LerNome()
        {
            while (true)
            {
                Console.Write("Nome: ");
                var nome = Console.ReadLine()?.Trim();

                if (!string.IsNullOrWhiteSpace(nome))
                {
                    return nome;
                }

                Console.WriteLine("O nome é obrigatório.");
                Console.WriteLine();
            }
        }
        private static DateOnly LerDataNacimento()
        {
            while (true)
            {
                Console.Write("Data de nascimento (dd/mm/yyyy): ");
                var data = Console.ReadLine();

                if (DateOnly.TryParse(data, out var dataNascimento))
                {
                    return dataNascimento;
                }

                Console.WriteLine("Data de nascimento inválida.");
                Console.WriteLine();
            }
        }
        private static void AguardarContinuacao()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        private static void ImprimirCliente(Cliente cliente)
        {
            Console.WriteLine($"ID....................: {cliente.Id}");
            Console.WriteLine($"Nome..................: {cliente.Nome}");
            Console.WriteLine($"Desconto..............: {cliente.Desconto}%");
            Console.WriteLine($"Data de nascimento....: {cliente.DataNascimento:dd/MM/yyyy}");
            Console.WriteLine($"Data de cadastro......: {cliente.CadastradoEm:dd/MM/yyyy HH:mm}");
            Console.WriteLine("----------------------------------------------");
        }

        private static int LerCodigoCliente()
        {
            while (true)
            {
                Console.Write("Informe o código do cliente: ");
                var entrada = Console.ReadLine();

                if (int.TryParse(entrada, out var codigo) && codigo > 0)
                {
                    return codigo;
                }

                Console.WriteLine("Código inválido.");
                Console.WriteLine();
            }
        }

        private Cliente BuscarPorId(int id)
        {
            var resutado = _clientes.FirstOrDefault(cliente => cliente.Id == id);
            return resutado;
        }

        public void SalvarDados()
        {
            var json = JsonSerializer.Serialize(_clientes, OpcoesJson);

            File.WriteAllText(NomeArquivo, json);
        }

        public void CarregarDados()
        {
            if (!File.Exists(NomeArquivo))
                return;

            var dados = File.ReadAllText(NomeArquivo);

            if (string.IsNullOrWhiteSpace(dados))
                return;

            var clientesArquivo = JsonSerializer.Deserialize<List<Cliente>>(dados, OpcoesJson);

            if (clientesArquivo is null)
                return;

            _clientes.Clear();
            _clientes.AddRange(clientesArquivo);
        }
    }
}
