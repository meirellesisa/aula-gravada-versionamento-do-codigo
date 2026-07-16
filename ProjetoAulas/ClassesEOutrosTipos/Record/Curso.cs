namespace ProjetoAulas.ClassesEOutrosTipos.Record
{
    //public class Curso
    //{
    //    public int Id { get; set; }
    //    public string Descricao { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj == null)
    //            return false;

    //        if (obj is Curso curso)
    //        {
    //            var validacao = Id == curso.Id && Descricao == curso.Descricao;
    //            return validacao;
    //        }

    //        return false;
    //    }

    //    public static bool operator ==(Curso a, Curso b)
    //    {
    //        return a.Equals(b);
    //    }

    //    public static bool operator !=(Curso a, Curso b)
    //    {
    //        return !(a.Equals(b));
    //    }
    //}

    public record Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        // Isso é feito automaticamente pelo compilador quando você usa record,
        // então não é necessário sobrescrever Equals e os operadores == e != manualmente.

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;

        //    if (obj is Curso curso)
        //    {
        //        var validacao = Id == curso.Id && Descricao == curso.Descricao;
        //        return validacao;
        //    }

        //    return false;
        //}

        //public static bool operator ==(Curso a, Curso b)
        //{
        //    return a.Equals(b);
        //}

        //public static bool operator !=(Curso a, Curso b)
        //{
        //    return !(a.Equals(b));
        //}

        public static void ExemploRecord()
        {

            //var curso1 = new Curso
            //{
            //    Id = 1,
            //    Descricao = "Curso"
            //};

            //var curso2 = new Curso
            //{
            //    Id = 1,
            //    Descricao = "Curso"
            //};

            //Console.WriteLine(curso1.Equals(curso2));

            var curso1 = new Curso
            {
                Id = 1,
                Descricao = "Curso"
            };

            var curso2 = curso1 with
            {
                Descricao = "Curso Banco de Dados"
            };

            //var curso2 = new Curso(1, "Curso");
            Console.WriteLine(curso1 == curso2);
        }
    }

    //public record Curso(int Id, string Descricao);
}
