using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                new Ornek(i);
                Console.WriteLine("****************");
                GC.Collect();
                Console.Read();
            }
        }

        class Ornek
        {
            int numara;
            public Ornek(int id)
            {
                numara = id;
                Console.WriteLine(numara + "nesne üretildi");

            }


            #region Destructor

            ~Ornek()
            {
                Console.WriteLine(numara + "nesne siliniyor");

            }
            #endregion
        }
    }
}
