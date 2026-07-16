namespace ProjetoAulas.ClassesEOutrosTipos.Polimorfismo
{
    public class Cachorro02 : Animal02
    {
        public override void EmitirSom()
        {
            base.EmitirSom();
            Console.WriteLine("AU AU");
        }

        public static void ExemploPolimorfismo()
        {
            var cachorro = new Cachorro02();
            cachorro.EmitirSom();


            var gato = new Gato();
            gato.EmitirSom();

            Animal02 animal = new Cachorro02();

            animal = new Gato();

            animal.EmitirSom();
        }
    }
}
