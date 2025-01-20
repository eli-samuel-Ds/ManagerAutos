using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAutos
{
    internal class GestionVehiculos
    {
        //Atributos
        private List<Vehiculo> vehiculos;

        //Propiedades
        public List<Vehiculo> Vehiculos 
        {
            get => vehiculos;
            private set => vehiculos = value;
        }

        //Constructor
        public GestionVehiculos(List<Vehiculo> vehiculos)
        {
            Vehiculos = vehiculos ?? new List<Vehiculo>();
        }

        public GestionVehiculos()
        {
            Vehiculos = new List<Vehiculo>();
        }
        //Comportamiento
        public void AgregarVehiculos(List<Vehiculo> vehiculo)
        {
            Vehiculos.AddRange(vehiculo);
        }
        private static int Conteo = 0;
        public void MostrarVehiculos()
        {
            Console.WriteLine("Lista de Vehiculos:");
            foreach (Vehiculo vehiculo in Vehiculos)
            {
                Console.WriteLine($"-{Conteo} {vehiculo.MostrarInformacion()} -");
                Conteo++;
            }
        }
        public void ConducirTodos()
        {
            Console.WriteLine("Conduciendo los Vehículos:");
            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.Conducir();
            }
        }
    }
}
