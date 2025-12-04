using System.Reflection.Metadata.Ecma335;

namespace Tarea01
{
    internal class Program
    {
        static int LeerNumero(string mensaje)
        {
            int num;
            bool esCorrecto;

            do
            {
                Console.Write(mensaje);
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (!esCorrecto)
                {
                    Console.WriteLine("\n\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static bool EsPar(int num)
        {
            bool esPar = false;

            if (num % 2 == 0)
            {
                esPar = true;
            }

            return esPar;
        }

        static bool ContinuarPeticiones(string mensaje)
        {
            bool esCorrecto;

            /*
            if (pregunta == "S" || pregunta == "s")
            {
                esCorrecto = true;
            }
            else if (pregunta == "N" || pregunta == "n")  
            {
                esCorrecto = false;
            }

            return esCorrecto;
            */

            esCorrecto = (mensaje == "S" || mensaje == "s") ? true
                       : (mensaje == "N" || mensaje == "n") ? false
                       : false;

            return esCorrecto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nC# - Tarea 1: Manuel MR ®\n" +
                              "═════════════════════════\n\n");

            int num;
            string mensaje;

            do
            {
                num = LeerNumero("\nIntroduce un número: ");

                if (EsPar(num))
                {
                    Console.WriteLine($"\n═> El número {num} es par.");
                }
                else
                {
                    Console.WriteLine($"\n═> El número {num} es impar.");
                }

                do
                {
                    Console.Write("\n¿Desesas introducir otro valor? (S/N): ");
                    mensaje = Console.ReadLine();

                    if ((mensaje != "S" && mensaje != "s") &&
                        (mensaje != "N" && mensaje != "n"))
                    {
                        Console.WriteLine("\nDebes introducir \"S\" o \"N\"");
                    }

                } while ((mensaje != "S" && mensaje != "s") &&
                        (mensaje != "N" && mensaje != "n"));


            } while (ContinuarPeticiones(mensaje));

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
