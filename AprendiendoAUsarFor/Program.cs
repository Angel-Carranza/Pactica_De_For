using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoAUsarFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses;

            meses = 12;
            for (anos = 1; anos <= 15; anos++)
            {

                Console.WriteLine("{0} años -> {1} meses", anos, meses);
                meses = meses + 12;
            }
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
