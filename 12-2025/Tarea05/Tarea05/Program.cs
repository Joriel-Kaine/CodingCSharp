namespace Tarea05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nC# - Tarea 4: Manuel MR ®\n" +
                              "═════════════════════════\n\n");

            int num, mayor = 0, menor = 0, contador = 0, suma = 0;
            double media = 0;
            bool esCorrecto;

            do
            {
                Console.Write("\nIntroduce un número entero: ");
                esCorrecto = int.TryParse(Console.ReadLine(), out num);

                if (esCorrecto)
                {
                    if (num > 0)
                    {
                        if (mayor == 0 && menor == 0)
                        {
                            mayor = menor = num;
                        }

                        if (num > mayor)
                        {
                            mayor = num;
                        }
                        else if (num < menor)
                        {
                            menor = num;
                        }
                        contador++;
                        suma += num;
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("\nEl número introducido no debe ser menor de 0");
                    }
                }
                else
                {
                    Console.WriteLine("\nDebes introducir valores numéricos válidos.");
                }

            } while (num != 0 || !esCorrecto);

            if (contador != 0)
            {
                media = (double)suma / contador;
            }

            Console.WriteLine($"\n═> El número mayor de todos es: {mayor}\n" +
                              $"\n═> El número menor de todos es: {menor}\n" +
                              $"\n═> La cantidad total de números introducidos es: {contador}\n" +
                              $"\n═> La media de todos los números introducidos es: {media:N2}");

            Console.WriteLine("\n\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
