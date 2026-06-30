namespace ProjetoAulas.EstruturasDeControle
{
    public class AulaSwitch
    {
        public static void Executar()
        {
            int diaDaSemana = 2;

            switch (diaDaSemana)
            {
                case 0:
                    Console.WriteLine("Hoje é domingo");
                    break;
                case 1:
                    Console.WriteLine("Hoje é segunda");
                    break;
                case 2:
                    Console.WriteLine("Hoje é terça");
                    break;
                case 3:
                    Console.WriteLine("Hoje é quarta");
                    break;
                case 4:
                    Console.WriteLine("Hoje é quinta");
                    break;
                case 5:
                    Console.WriteLine("Hoje é sexta");
                    break;
                case 6:
                    Console.WriteLine("Hoje é sabado");
                    break;
                default:
                    Console.WriteLine("Valor inválido para o dia da semana");
                    break;
            }

        }
    }
}
