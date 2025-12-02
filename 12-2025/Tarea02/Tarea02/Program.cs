namespace Tarea02
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
                    Console.WriteLine("\nIntroduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static bool ContinuarPeticion(string respuesta)
        {
            bool esCorrecto = false;

            if (respuesta == "S" || respuesta == "s")
            {
                esCorrecto = true;
            }
            else if (respuesta == "N" || respuesta == "n")
            {
                esCorrecto = false;
            }

            return esCorrecto;
        }

        static int DevolverAbsoluto(int num)
        {
            return num > 0 ? num : -num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nC# - Tarea 02: Manuel MR ®\n" +
                              "══════════════════════════\n\n");

            int num;
            string respuesta;

            do
            {
                num = LeerNumero("\nIntroduce un número: ");
                Console.WriteLine($"\n═> El valor absoluto de {num} es {DevolverAbsoluto(num)}");

                do
                {
                    Console.Write("\n¿Desea introducir otro número? S/N: ");
                    respuesta = Console.ReadLine();

                    if ((respuesta != "S" && respuesta != "s") &&
                          (respuesta != "N" && respuesta != "n"))
                    {
                        Console.WriteLine("\nDebes introducir \"S\" o \"N\".");
                    }

                } while ((respuesta != "S" && respuesta != "s") &&
                          (respuesta != "N" && respuesta != "n"));

            } while (ContinuarPeticion(respuesta));

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
