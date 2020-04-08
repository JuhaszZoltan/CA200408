using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200408
{
    class Program
    {
        static void Main(string[] args)
        {

            Kutya[] kt = new Kutya[10];

            for (int i = 0; i < 10; i++)
            {
                kt[i] = new Kutya("Hektor", 2, "2000-02-02", 10);
            }
            
            var k = new Kutya("Bodri", 2, "2015-03-08", 80);

            k.Eszik(0.7F);
            k.Ugat();
            Console.WriteLine(k.Suly);
            k.Eszik(0.5F);

            Console.WriteLine();

            Console.WriteLine(k.Suly);
            Console.ReadKey();
        }
    }
}
