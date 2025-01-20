using System;
using ManagerAutos;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia y Creacion
            Auto auto1 = new Auto("toyota","yipeta",2010, 4);
            Auto auto2 = new Auto("kia", "guagua", 2010, 6);
            Auto auto3 = new Auto("yundai", "yipeta", 2012, 4);
            Auto auto4 = new Auto("honda", "miniban", 2024, 3);

            Motocicleta moto1 = new Motocicleta("toyota", "moto", 2010, true);
            Motocicleta moto2 = new Motocicleta("nichan", "moto", 2012, true);
            Motocicleta moto3 = new Motocicleta("yamaja", "moto", 2002, true);
            Motocicleta moto4 = new Motocicleta("yatai", "moto", 2024, true);

            //Agregar Autos y Motos
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            listaVehiculos.Add(auto1);
            listaVehiculos.Add(auto2);
            listaVehiculos.Add(auto3);
            listaVehiculos.Add(auto4);

            listaVehiculos.Add(moto1);
            listaVehiculos.Add(moto2);
            listaVehiculos.Add(moto3);
            listaVehiculos.Add(moto4);

            GestionVehiculos gestionVehiculos = new GestionVehiculos();
            gestionVehiculos.AgregarVehiculos(listaVehiculos);

            //Imprimiendo informacion
            Console.WriteLine("Gestion De Vehiculos");

            //Mostrando toda la informacion de los vehiculos
            gestionVehiculos.MostrarVehiculos();
            Console.WriteLine();
            gestionVehiculos.ConducirTodos();
        }
    }
}