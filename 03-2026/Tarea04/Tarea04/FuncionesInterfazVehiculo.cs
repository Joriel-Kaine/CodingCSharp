using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea04
{
    public static class FuncionesInterfazVehiculo
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

        public static int LeerDouble(string mensaje)
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

        public static void AgregarVehiculo(ListaVehiculos listaVehiculos)
        {
            string matricula = Interaction.InputBox("Introduce la matrícula:");
            string marca = Interaction.InputBox("Introduce la marca:");
            string modelo = Interaction.InputBox("Introduce el modelo:");
            int yearFabricacion = LeerEntero("Introduce el año de fabricación:");
            double precio = LeerDouble("Introduce el precio:");

            Vehiculo vehiculo = new(matricula, marca, modelo, yearFabricacion, precio);

            listaVehiculos.AddVehiculo(vehiculo);

            MessageBox.Show("Vehiculo agregado.");
        }
    }
}
