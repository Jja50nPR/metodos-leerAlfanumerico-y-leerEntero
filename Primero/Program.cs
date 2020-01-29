using System;

namespace Primero
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = leerAlfaNumerico("Ingrese el nombre ");
            int age = leerEntero("Ingrese la edad ");

           Console.WriteLine($"La edad de {name} es {age}");

            Console.WriteLine(Suma(7, 8));

            Console.WriteLine("Hello world gguguguiguiguigguggigkugk");
        }

        public static int Suma(int v1, int v2) => v1 + v2;

        static String leerAlfaNumerico(String pMensaje)
        {
            Console.WriteLine(pMensaje);
            String dato = Console.ReadLine();
            return dato;
        }

        static int leerEntero(String pMensaje)
        {
            int bandera = 0;
            int dato = 0;
            Console.WriteLine(pMensaje);
            while (bandera == 0)
            {
                try
                {
                    dato = int.Parse(Console.ReadLine());
                    bandera++;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Has introducido un valor equivocado");
                    Console.WriteLine("Vuelva ha introducir el valor");
                }
            }
           
            return dato;
        }

        public static void Nada()
        {
            Console.WriteLine("Hello world");

        }
    }
}
