using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03
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

                if (num <= -50 || num >= 150)
                {
                    MessageBox.Show("Valores fuera de rango.");
                }

            } while (!esCorrecto || (num <= -50 || num >= 150));

            return num;
        }

        public static void LeerVector(int[] vector)
        {
            int tamano = vector.Length;

            for (int i = 0; i < tamano; i++)
            {
                vector[i] = LeerEntero("Introduce un valor:");
            }
        }

        public static string MostrarVector(int[] vector)
        {
            int tamano = vector.Length;
            string texto = "Valores del vector:\n";

            for (int i = 0; i < tamano; i++)
            {
                texto += $"{vector[i]}, ";
            }

            return texto;
        }

        public static void PosicionMayorValor(int[] vector, out int mayor, out int posicion)
        {
            int tamano = vector.Length;
            mayor = vector[0];
            posicion = 0;

            for (int i = 1; i < tamano; i++)
            {
                if (mayor < vector[i])
                {
                    mayor = vector[i];
                    posicion = i;
                }
            }
        }

        public static int[] ValoresNegativos(int[] vector)
        {
            int tamano = vector.Length, count = 0;

            for (int i = 0; i < tamano; i++)
            {
                if (vector[i] < 0)
                {
                    count++;
                }
            }

            int[] vectorNegativos = new int[count];
            int j = 0;

            for (int i = 0; i < tamano; i++)
            {
                if (vector[i] < 0)
                {
                    vectorNegativos[j] = vector[i];
                    j++;
                }
            }

            return vectorNegativos;
        }

        public static int ContarValores(int[] vector)
        {
            int tamano = vector.Length, count = 0;

            for (int i = 0; i < tamano; i++)
            {
                if (vector[i] >= 0 && vector[i] <= 50)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
