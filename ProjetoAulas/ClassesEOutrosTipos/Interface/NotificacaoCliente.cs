namespace ProjetoAulas.ClassesEOutrosTipos.Interface
{
    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get ; set ; }

        public void Notificar()
        {
            Console.WriteLine($"Notificando cliente");
        }

        public static void ExemploInterface01()
        {
            var notificacaoCliente = new NotificacaoCliente();
            notificacaoCliente.Notificar();

            //var interfaceTeste = new INotificacao(); -> isso não é possível, pois não podemos instanciar uma interface
        }
    }
}
