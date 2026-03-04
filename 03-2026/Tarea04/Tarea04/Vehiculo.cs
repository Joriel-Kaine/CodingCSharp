using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea04
{
    public class Vehiculo
    {
        // Campo.
        private string _matricula;
        private string _marca;
        private string _modelo;
        private int _yearFabricacion;
        private double _precio;
        private List<double> _listaRevisiones = new();

        // Propiedad.
        public string Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public int YearFabricacion
        {
            get { return _yearFabricacion; }
            set
            {
                if (value > 1900)
                {
                    _yearFabricacion = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Error de rango.");
                }
            }
        }

        public double Precio
        {
            get { return _precio; }
            set
            {
                if (value > 0)
                {
                    _precio = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Error de rango.");
                }
            }
        }

        // Constructor.
        public Vehiculo()
        {
            Matricula = "";
            Marca = "";
            Modelo = "";
            YearFabricacion = 1901;
            Precio = 1;
        }

        public Vehiculo(string matricula, string marca, string modelo,
                        int yearFabricacion, double precio)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
            YearFabricacion = yearFabricacion;
            Precio = precio;
        }

        // Método.
        public void AddRevision(double importe)
        {
            if (importe > 0)
            {
                _listaRevisiones.Add(importe);
            }
        }

        private string GenerarTextoRevisiones()
        {
            int tamano = _listaRevisiones.Count;
            string texto = "Revisiones: ";

            for (int i = 0; i < tamano; i++)
            {
                texto += $"{_listaRevisiones[i]}, ";
            }

            return texto;
        }

        private double SumaRevisiones()
        {
            int tamano = _listaRevisiones.Count;
            double suma = 0.0;

            for (int i = 0; i < tamano; i++)
            {
                suma += _listaRevisiones[i];
            }

            return suma;
        }

        public double MediaRevisiones()
        {
            int tamano = _listaRevisiones.Count;
            double media = 0.0;

            if (tamano > 0)
            {
                media = SumaRevisiones() / tamano;
            }

            return media;
        }

        public string GenerarTextoDatos()
        {
            string texto = $"Datos del vehículo:\n" +
                           $"Matrícula: {Matricula}\n" +
                           $"Marca: {Marca}\n" +
                           $"Modelo: {Modelo}\n" +
                           $"Año de fabricación: {YearFabricacion}\n" +
                           $"Precio: {Precio}\n" +
                           $"\n{GenerarTextoRevisiones()}";

            return texto;
        }
    }
}
