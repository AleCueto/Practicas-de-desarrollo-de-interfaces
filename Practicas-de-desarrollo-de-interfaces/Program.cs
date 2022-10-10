using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_de_desarrollo_de_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double area;

            Console.Write("Introduce un valor para el radio en metros: ");
            radio = Convert.ToInt32(Console.ReadLine());


            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"El área del círculo del radio {radio} es {area} metros cuadrados");

        }
    }
}
