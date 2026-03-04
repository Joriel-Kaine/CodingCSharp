using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea04
{
    public class ListaVehiculos
    {
        // Campo.
        private List<Vehiculo> _listaVehiculos = new();

        // Método.
        private int BuscarVehiculo(string matricula)
        {
            int posicion = -1, tamano = _listaVehiculos.Count;
            bool esEncontrado = false;

            for (int i = 0; i < tamano && !esEncontrado; i++)
            {
                if (_listaVehiculos[i].Matricula.ToLower() == matricula.ToLower())
                {
                    posicion = i;
                    esEncontrado = true;
                }
            }

            return posicion;
        }

        public void AddVehiculo(Vehiculo vehiculo)
        {
            _listaVehiculos.Add(vehiculo);
        }

        public bool EliminarPorMatricula(string matricula)
        {
            int posicion;
            bool esCorrecto = false;

            posicion = BuscarVehiculo(matricula);

            if (posicion >= 0)
            {
                _listaVehiculos.RemoveAt(posicion);
                esCorrecto = true;
            }

            return esCorrecto;
        }

        public Vehiculo? BuscarPorMatricula(string matricula)
        {
            Vehiculo? vehiculo = null;
            int posicion;

            posicion = BuscarVehiculo(matricula);

            if (posicion >= 0)
            {
                vehiculo = _listaVehiculos[posicion];
            }

            return vehiculo;
        }

        public string GenerarTextoListaCompleta()
        {
            int tamano = _listaVehiculos.Count;
            string texto = "Lista de vehículos:\n";

            for (int i = 0; i < tamano; i++)
            {
                texto += $"{_listaVehiculos[i].GenerarTextoDatos()}\n\n";
            }

            return texto;
        }

        public string GenerarTextoMatriculas()
        {
            int tamano = _listaVehiculos.Count;
            string texto = "Lista de matrículas:\n";

            for (int i = 0; i < tamano; i++)
            {
                texto += $"{i + 1} - {_listaVehiculos[i].Matricula}\n";
            }

            return texto;
        }

        public Vehiculo VehiculoMasCaro()
        {
            Vehiculo vehiculoMasCaro = _listaVehiculos[0];
            int tamano = _listaVehiculos.Count;

            for (int i = 1; i < tamano; i++)
            {
                if (vehiculoMasCaro.Precio < _listaVehiculos[i].Precio)
                {
                    vehiculoMasCaro = _listaVehiculos[i];
                }
            }

            return vehiculoMasCaro;
        }

        private void Swap(int i, int j)
        {
            Vehiculo aux = _listaVehiculos[i];
            _listaVehiculos[i] = _listaVehiculos[j];
            _listaVehiculos[j] = aux;
        }

        public void OrdenarPorPrecioAscendente()
        {
            int tamano = _listaVehiculos.Count;

            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = i + 1; j < tamano; j++)
                {
                    if (_listaVehiculos[i].Precio > _listaVehiculos[j].Precio)
                    {
                        Swap(i, j);
                    }
                }
            }
        }

        public void OrdenarPorMarcaModelo()
        {
            int tamano = _listaVehiculos.Count;

            for (int i = 0; i < tamano - 1; i++)
            {
                for (int j = i + 1; j < tamano; j++)
                {
                    if (_listaVehiculos[i].Marca.ToLower().CompareTo(_listaVehiculos[j].Marca.ToLower()) == 0)
                    {
                        if (_listaVehiculos[i].Modelo.ToLower().CompareTo(_listaVehiculos[j].Modelo.ToLower()) > 0)
                        {
                            Swap(i, j);
                        }
                    }
                    else if (_listaVehiculos[i].Marca.ToLower().CompareTo(_listaVehiculos[j].Marca.ToLower()) > 0)
                    {
                        Swap(i, j);
                    }
                }
            }
        }
    }
}
