namespace Tarea03
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

        static void CambiarAbsoluto(ref int num)
        {
            if (num < 0)
            {
                num = -num;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nC# - Tarea 3: Manuel MR ®\n" +
                              "═════════════════════════\n\n");

            int num;

            num = LeerNumero("\nIntroduce un número: ");

            CambiarAbsoluto(ref num);
            Console.WriteLine($"\n═> El valor absoluto es {num}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
