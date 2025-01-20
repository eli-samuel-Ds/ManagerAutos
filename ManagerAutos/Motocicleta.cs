using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAutos
{
    internal class Motocicleta : Vehiculo
    {
        //Atributo
        private bool tieneSiDeCar;

        //Propiedades
        public bool TieneSiDeCar
        {
            get => tieneSiDeCar;
            set => tieneSiDeCar = value;
        }

        //Constructor
        public Motocicleta(string marca, string modelo, int anio, bool tieneSiDeCar)
            : base(marca, modelo, anio)
        {
            TieneSiDeCar = tieneSiDeCar;
        }

        //Comportamiento
        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo una Motocicleta: {base.MostrarInformacion()} " +
                $"y tienes si de car: {TieneSiDeCar} ");
        }
    }
}
