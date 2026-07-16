namespace ProjetoAulas.ClassesEOutrosTipos.SobrecargaMetodo
{
    public class Calculos02
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //public int Somar(int parametro1, int parameto2)
        //{
        //    return parametro1 + parameto2;
        //}

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }

        public static void ExemploSobrecargaMetodo()
        {

            var calculo = new Calculos02();
            Console.WriteLine(calculo.Somar(2, 3));

            Console.WriteLine(calculo.Somar(2, 3, 5));

            Console.WriteLine(calculo.Somar(2.5, 3.5));
        }
    }
}
