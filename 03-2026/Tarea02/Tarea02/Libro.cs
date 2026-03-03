using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02
{
    public class Libro
    {
        // Campo.
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int YearPublicacion { get; set; }
        private List<double> _valoraciones = new();

        // Constructor.
        public Libro()
        {
            Titulo = "";
            Autor = "";
            YearPublicacion = 0;
        }

        public Libro(string titulo, string autor, int yearPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            YearPublicacion = yearPublicacion;
        }

        // Método.
        public void AddValoracion(double valoracion)
        {
            if (valoracion >= 0 && valoracion <= 10)
            {
                _valoraciones.Add(valoracion);
            }
        }

        private double SumaValoraciones()
        {
            double suma = 0.0;
            int tamano = _valoraciones.Count;

            for (int i = 0; i < tamano; i++)
            {
                suma += _valoraciones[i];
            }

            return suma;
        }

        public double MediaValoraciones()
        {
            double media = 0.0;

            if (_valoraciones.Count > 0)
            {
                media = SumaValoraciones() / _valoraciones.Count;
            }

            return media;
        }

        public string GenerarTextoValoraciones()
        {
            string texto = "Valoraciones: ";
            int tamano = _valoraciones.Count;

            if (tamano > 0)
            {
                for (int i = 0; i < tamano; i++)
                {
                    texto += $"{_valoraciones[i]}, ";
                }
            }
            else
            {
                texto = "Libro sin valoraciones.";
            }

            return texto;
        }

        public string GenerarTextoDatos()
        {
            string texto = "Datos del libro:\n";

            return texto += $"Título: {Titulo}\n" +
                            $"Autor: {Autor}\n" +
                            $"Año de publicación: {YearPublicacion}\n" +
                            GenerarTextoValoraciones();
        }
    }
}
