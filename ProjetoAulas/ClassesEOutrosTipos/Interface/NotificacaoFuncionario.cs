namespace ProjetoAulas.ClassesEOutrosTipos.Interface
{
    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando funcionário");
        }

        public static void ExemploInterface02()
        {
            //var notificacaoFuncionario = new NotificacaoFuncionario();
            //notificacaoFuncionario.Notificar();


            INotificacao notificacao = new NotificacaoFuncionario();
            notificacao.Notificar();

            //var interfaceTeste = new INotificacao(); -> isso não é possível, pois não podemos instanciar uma interface
        }
    }
}
