using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01
{
    public static class FuncionesVector
    {
        public static int LeerEntero(string mensaje)
        {
            int num;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);
                esCorrecto = int.TryParse(texto, out num);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.");
                }

                if (num < 0 || num > 100)
                {
                    MessageBox.Show("Valor fuera de rango.");
                }

            } while (!esCorrecto || (num < 0 || num > 100));

            return num;
        }

        public static void LeerVector(int[] vector)
        {
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                vector[i] = LeerEntero("Introduce un valor: ");
            }
        }

        public static string GenerarTextoVector(int[] vector)
        {
            string texto = "Elementos del vector:\n";
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                texto += $"{vector[i]}, ";
            }

            return texto;
        }

        public static int SumarVector(int[] vector)
        {
            int suma = 0, tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                suma += vector[i];
            }

            return suma;
        }

        public static string GenerarTextoParesVector(int[] vector)
        {
            string texto = "Pares del vector:\n";
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                if (vector[i] % 2 == 0)
                {
                    texto += $"{vector[i]}, ";
                }
            }

            return texto;
        }

        public static int BuscarPrimeraPosicionVector(int[] vector, int valor)
        {
            int tamano = vector.Length, posicion = -1;
            bool esEncontrado = false;

            for (int i = 0; i < tamano && !esEncontrado; i++)
            {
                if (vector[i] == valor)
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }
    }
}
