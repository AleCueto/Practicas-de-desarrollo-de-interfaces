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

            //Practica3();

            //Practica4();

            Practica5();
            
            //Excepciones();
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

            if (edad >= EDAD_MINIMA_CARNET_CONDUCIR)
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

            while (respuesta != "S" && respuesta != "N") {

                Console.Write("El valor no es correcto, debe ser una S o una N: ");
                respuesta = Console.ReadLine();
            }

            return respuesta;

        }


        static void Practica4()
        {

            Console.WriteLine("¿Quieres entrar? S/N");

            Console.Write("respuesta: ");
            string respuesta2 = LeerRespuesta2(Console.ReadLine());
            Console.WriteLine("Bien, has introducido S o N"); ;
        }

        static string LeerRespuesta2(string respuesta)
        {

            do
            {
                if (respuesta != "S" && respuesta != "N")
                {
                    Console.Write("El valor no es correcto, debe ser una S o una N: ");
                    respuesta = Console.ReadLine();
                }
            } while (respuesta != "S" && respuesta != "N");

            return respuesta;

        }


        static void Excepciones()
        {
            try {
                Console.WriteLine("Introduce un número:");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se ha leido {valor}");
            }
            catch (FormatException ex) {
                Console.WriteLine("El formato del número no es correcto");
            }
            catch (OverflowException ex) {
                Console.WriteLine("El número introducido es demasiado grande");
            }
        }


        static void Excepciones2()
        {
            try
            {
                Console.WriteLine("Introduce un número:");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Se ha leido {valor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Practica5(){

            const string PATH = @"C:\Users\Estudios\Desktop\Nuevo.txt";

            System.IO.StreamReader archivo = null;
            string linea = string.Empty;

            try {
                archivo = new System.IO.StreamReader(PATH);
                linea = archivo.ReadLine();
                while(!String.IsNullOrEmpty(linea))
                {
                    Console.WriteLine(linea);
                    linea = archivo.ReadLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(archivo != null) 
                {
                    archivo.Close();
                }

                Console.WriteLine("Conexión con el fichero cerrada");
            }
        }
    }
}