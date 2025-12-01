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

        static bool ContinuarPeticiones(string pregunta)
        {
            bool esCorrecto = false;

            if (pregunta == "S" || pregunta == "s")
            {
                esCorrecto = true;
            }
            else if (pregunta == "N" || pregunta == "n")  
            {
                esCorrecto = false;
            }

            return esCorrecto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nC# - Tarea 1: Manuel MR ®\n" +
                              "═════════════════════════\n\n");

            int num;
            string pregunta;

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
                    pregunta = Console.ReadLine();

                    if ((pregunta != "S" && pregunta != "s") &&
                        (pregunta != "N" && pregunta != "n"))
                    {
                        Console.WriteLine("\nDebes introducir \"S\" o \"N\"");
                    }

                } while ((pregunta != "S" && pregunta != "s") &&
                        (pregunta != "N" && pregunta != "n"));


            } while (ContinuarPeticiones(pregunta));

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
