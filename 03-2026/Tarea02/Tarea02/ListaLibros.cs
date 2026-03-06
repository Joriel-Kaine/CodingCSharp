using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02
{
    public class ListaLibros
    {
        // Campo.
        private List<Libro> _listaLibros = new();

        // Método.

        public int BuscarLibro(string titulo)
        {
            int posicion = -1, tamano = _listaLibros.Count;
            bool esEncontrado = false;

            for (int i = 0; i < tamano && !esEncontrado; i++)
            {
                if (_listaLibros[i].Titulo.ToLower() == titulo.ToLower())
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        public void AddLibro(Libro libro)
        {
            _listaLibros.Add(libro);
        }

        public bool EliminarPorTitulo(string titulo)
        {
            int posicion;
            bool esCorrecto = false;

            posicion = BuscarLibro(titulo);

            if (posicion >= 0)
            {
                _listaLibros.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public bool EliminarPorPosicion(int posicion)
        {
            bool esCorrecto = false;

            if (posicion >= 0 && posicion < _listaLibros.Count)
            {
                _listaLibros.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public string GenerarTextoListaCompleta()
        {
            string texto = "Lista de libros:\n";

            for (int i = 0; i < _listaLibros.Count; i++)
            {
                texto += $"{_listaLibros[i].GenerarTextoDatos()}\n";
            }

            return texto;
        }

        public string GenerarTextgoListaTitulos()
        {
            string texto = "Lista de títulos:\n";

            for (int i = 0; i < _listaLibros.Count; i++)
            {
                texto += $"{i + 1} - {_listaLibros[i].Titulo}\n";
            }

            return texto;
        }

        public bool AddValoraciones(string titulo, double valoracion)
        {
            bool esCorrecto = false;
            int posicion;

            posicion = BuscarLibro(titulo);

            if (posicion >= 0)
            {
                _listaLibros[posicion].AddValoracion(valoracion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public Libro? MostrarMediaMayor()
        {
            double mediaMayor = 0.0;
            Libro? libroMediaMayor = null;

            foreach (Libro libro in _listaLibros)
            {
                double media = libro.MediaValoraciones();

                if (mediaMayor < media)
                {
                    mediaMayor = media;
                    libroMediaMayor = libro;
                }
            }

            return libroMediaMayor;
        }

        public void Swap(int i, int j)
        {
            Libro aux;

            aux = _listaLibros[i];
            _listaLibros[i] = _listaLibros[j];
            _listaLibros[j] = aux;
        }

        public void OrdenarPorTitulo()
        {
            int tamano = _listaLibros.Count;

            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = i + 1; j < tamano; j++)
                {
                    if (_listaLibros[i].Titulo.ToLower().CompareTo(_listaLibros[j].Titulo.ToLower()) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        public void OrdenarPorMediaValoraciones()
        {
            int tamano = _listaLibros.Count;

            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = i + 1; j < tamano; j++)
                {
                    if (_listaLibros[i].MediaValoraciones() < _listaLibros[j].MediaValoraciones())
                    {
                        Swap(i, j);
                    }
                }
            }
        }
    }
}

