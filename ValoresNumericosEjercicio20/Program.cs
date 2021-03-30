using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericosEjercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int primero;
            int segundo;

            Console.WriteLine("Ingrese el primer número");
            if (!int.TryParse(Console.ReadLine(), out primero))
            {
                Console.WriteLine("Debe ingresar un número");
            }
            Console.WriteLine("Ingrese el primer número");
            if (!int.TryParse(Console.ReadLine(), out segundo))
            {
                Console.WriteLine("Debe ingresar un número");
            }
            if (primero < segundo)
            {
                Console.WriteLine($"Usted ingresó los números {primero} y {segundo}.\nDe los dos, el mayor es {segundo}");
            }
            else
            {
                Console.WriteLine($"Usted ingresó los números {primero} y {segundo}.\nDe los dos, el mayor es {primero}");
            }
            Console.ReadKey();

        }
    }
}
