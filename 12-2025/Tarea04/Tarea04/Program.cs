namespace Tarea04
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
                    Console.WriteLine("\nIntroduce valores numéricos válildos.");
                }

            } while (!esCorrecto);

            return num;
        }

        static bool DividirEnteros(int dividendo, int divisor, out int cociente, out int resto)
        {
            bool esCorrecto;

            if (divisor != 0)
            {
                esCorrecto = true;
                cociente = dividendo / divisor;
                resto = dividendo % divisor;
            }
            else
            {
                esCorrecto = false;
                cociente = 0;
                resto = 0;
            }

            return esCorrecto;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nC# - Tarea 4: Manuel MR ®\n" +
                              "═════════════════════════\n\n");

            int dividendo, divisor, cociente, resto;

            dividendo = LeerNumero("\nIntroduce el dividendo: ");
            divisor = LeerNumero("\nIntroduce el divisor: ");

            if (DividirEnteros(dividendo, divisor, out cociente, out resto))
            {
                Console.WriteLine($"\n═> La división de {dividendo} entre {divisor} tiene como " +
                                  $"cociente {cociente} y de resto {resto}");
            }
            else
            {
                Console.WriteLine("\nNo se puede dividir entre 0");
            }

                Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
