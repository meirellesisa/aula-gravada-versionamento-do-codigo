

using AppClientes.Aplicacao;
using AppClientes.Interfaces;
using AppClientes.Repositorios;


IClienteRespositorio clienteRepositorio = new ClienteRepositorio();

clienteRepositorio.CarregarDados();

var aplicacao = new AppClientesAplicacao(clienteRepositorio);

aplicacao.Executar();