namespace ProjetoAulas.EstruturasDeControle
{
    public class AulaIfElse
    {
        public static void Executar()
        {
            var diaDaSemana = 1;
            var diaDeTrabalho = true;

            if (diaDaSemana == 0 && diaDeTrabalho)
            {
                Console.WriteLine("Hoje é domingo");
            }
            else if (diaDaSemana == 0 && diaDeTrabalho == false)
            {
                Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
            }
            else
            {
                Console.WriteLine("Hoje não é domingo");
            }

            diaDaSemana = 10;

            if (diaDaSemana == 0)
            {
                Console.WriteLine("Hoje é domingo");
            }
            else if (diaDaSemana == 1)
            {
                Console.WriteLine("Hoje é segunda");
            }
            else if (diaDaSemana == 2)
            {
                Console.WriteLine("Hoje é terça");
            }
            else if (diaDaSemana == 3)
            {
                Console.WriteLine("Hoje é quarta");
            }
            else if (diaDaSemana == 4)
            {
                Console.WriteLine("Hoje é quinta");
            }
            else if (diaDaSemana == 5)
            {
                Console.WriteLine("Hoje é sexta");
            }
            else if (diaDaSemana == 6)
            {
                Console.WriteLine("Hoje é sabado");
            }
            else
            {
                Console.WriteLine("Valor inválido para o dia da semana");
            }

            diaDaSemana = 0;

            if (diaDaSemana < 1)
            {

                Console.WriteLine("Hoje é domingo");
            }
            else
            {
                Console.WriteLine("Dia da semana invalido");
            }
        }
    }
}
