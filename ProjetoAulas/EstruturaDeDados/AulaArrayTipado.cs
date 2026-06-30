namespace ProjetoAulas.EstruturaDeDados
{
    public class AulaArrayTipado
    {
        public static void Executar()
        {
            //var arrayTipadoNumero = new int[3] { 1, 2, 3 };
            var arrayTipadoNumero = new int[3];

            arrayTipadoNumero[0] = 5;
            arrayTipadoNumero[1] = 5;
            arrayTipadoNumero[2] = 10;

            Array.Resize(ref arrayTipadoNumero, 11);
            arrayTipadoNumero[10] = 100;

            foreach (var item in arrayTipadoNumero)
            {
                Console.WriteLine(item);
            }

            var arrayTipadoString = new string[2] { "Isabella", "Meirelles" };

            foreach (var item in arrayTipadoString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
