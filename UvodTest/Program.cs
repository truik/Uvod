using System;

namespace UvodTest
{
    class Program
    {
        static void Main(string[] args)
        {


            Equipment Cam = new Equipment { Name = "Kamera" };
            Equipment Kniha = new Equipment { Name = "Kniha" };
            Equipment Pero = new Equipment { Name = "Pero" };
            User Pepa = new User() { FirstName = "Pepa", LastName = "Zdepa", Days = 22, ID="32sd1" };
            User M = new User() { FirstName = "MMM", LastName = "NNN", Days = 2 , ID = "456465sdf" };
            User S = new User() { FirstName = "SSS", LastName = "DDD", Days = 1, ID = "asd1sds" };

            Cam.Borrow(Pepa);
            Cam.Borrow(Pepa);
            Kniha.Borrow(M);
            Pero.Borrow(S);

            Console.WriteLine(Cam);
            Console.WriteLine(Kniha);
            Console.WriteLine(Pero);

            Console.WriteLine(Math.Max(Math.Max(Pepa.Days, M.Days), S.Days));

            Console.Read();
        }
    }
}
