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

            //Practica1();

            //Practica2();

            Practica3();
        }

        #region Pactica 1

        static void Practica1()
        {
            double radio;
            double area;

            Console.Write("Introduce un valor para el radio en metros: ");
            radio = Convert.ToInt32(Console.ReadLine());



            area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine($"El área del círculo del radio {radio} es {area} metros cuadrados");
        }

        #endregion

        #region Practica 2
        static void Practica2()
        {
            string respuesta;
            int edad;

            const string TIENE_CARNET = "S";
            const int EDAD_MINIMA_CARNET_CONDUCIR = 18;

            Console.Write("¿Qué edad tienes?: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if(edad >= EDAD_MINIMA_CARNET_CONDUCIR)
            {
                Console.Write("¿Tienes carnet de conducir?: ");
                respuesta = Console.ReadLine().ToUpper();

                if (respuesta.Equals(TIENE_CARNET))
                {
                    Console.WriteLine("Felicidades, puedes conducir");
                }
                else
                {
                    Console.WriteLine("Lo siento, no puedes conducir");
                }
            }
            else
            {
                Console.WriteLine("Lo siento, no puedes conducir");
            }


        }
        #endregion


        static void Practica3() {
        
            Console.WriteLine("¿Quieres entrar? S/N");

            Console.Write("respuesta: ");
            string respuesta2 = LeerRespuesta(Console.ReadLine());
            Console.WriteLine("Bien, has introducido S o N"); ;
        }

        static string LeerRespuesta(string respuesta)
        {

            while(respuesta != "S" && respuesta != "N") {

                Console.Write("El valor no es correcto, debe ser una S o una N: ");
                respuesta = Console.ReadLine();
            }

            return respuesta;

        }


    }
}