using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Introduce un número: ");
                a = Convert.ToInt32 (Console.ReadLine());

            Console.Write("Introduce un número: ");
                b = Convert.ToInt32 (Console.ReadLine());

                c = a + b;

            Console.WriteLine("La suma de los números es: " + c);
            Console.ReadKey();

        }
    }
}
