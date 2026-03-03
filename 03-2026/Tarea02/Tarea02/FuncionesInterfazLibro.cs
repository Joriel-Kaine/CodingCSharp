using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02
{
    public static class FuncionesInterfazLibro
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

            } while (!esCorrecto);

            return num;
        }

        public static double LeerDouble(string mensaje)
        {
            double num;
            bool esCorrecto;
            string texto;

            do
            {
                texto = Interaction.InputBox(mensaje);
                esCorrecto = double.TryParse(texto, out num);

                if (!esCorrecto)
                {
                    MessageBox.Show("Introduce valores numéricos válidos.");
                }

            } while (!esCorrecto);

            return num;
        }

        public static void AddLibro(ListaLibros listaLibros)
        {
            string titulo = Interaction.InputBox("Introduce el título:");
            string autor = Interaction.InputBox("Introduce el autor:");
            int yearPublicacion = LeerEntero("Introduce el año de publicación:");

            Libro libro = new(titulo, autor, yearPublicacion);

            listaLibros.AddLibro(libro);

            MessageBox.Show("Libro añadido.");
        }

        public static void EliminarPorTitulo(ListaLibros listaLibros)
        {
            string titulo = Interaction.InputBox("Introduce el título:");

            if (listaLibros.EliminarPorTitulo(titulo))
            {
                MessageBox.Show("Libro eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No existe el libro.");
            }
        }

        public static void EliminarPorPosicion(ListaLibros listaLibros)
        {
            int posicion = LeerEntero("Introduce la posición:");

            if (listaLibros.EliminarPorPosicion(posicion))
            {
                MessageBox.Show("Libro eliminador correctamente.");
            }
            else
            {
                MessageBox.Show("No existe el libro.");
            }
        }

        public static void MostrarTodo(ListaLibros listaLibros)
        {
            MessageBox.Show(listaLibros.GenerarTextoListaCompleta());
        }

        public static void MostrarListaTitulos(ListaLibros listaLibros)
        {
            MessageBox.Show(listaLibros.GenerarTextgoListaTitulos());
        }

        public static void AddValoracionesLibro(ListaLibros listaLibros)
        {
            string titulo = Interaction.InputBox("Introduce el título:");
            double valoracion = LeerDouble("Introduce la valoración.");

            if (listaLibros.AddValoraciones(titulo, valoracion))
            {
                MessageBox.Show("Valoración añadida.");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el título.");
            }
        }

        public static void MostrarMejorMedia(ListaLibros listaLibros)
        {
            Libro? libro = listaLibros.MostrarMediaMayor();

            if (libro != null)
            {
                MessageBox.Show($"El libro con la media mayor es: {libro.GenerarTextoDatos()}" +
                                $"\nNota media: {libro.MediaValoraciones()}");
            }
            else
            {
                MessageBox.Show("El libro no existe.");
            }
        }

        public static void OrdenarPorTitulo(ListaLibros listaLibros)
        {
            listaLibros.OrdenarPorTitulo();

            MessageBox.Show("La lista se ha ordenado por título.");
        }

        public static void OrdenarPorValoracionMedia(ListaLibros listaLibros)
        {
            listaLibros.OrdenarPorMediaValoraciones();

            MessageBox.Show("La lista se ha ordenado por la media de valoraciones.");
        }
    }
}
