using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAutos
{
    internal class Auto : Vehiculo
    {
        //Atributo
        private int numeroPuertas;

        //Propiedad
        public int NumeroPuertas
        {
            get => numeroPuertas;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El numero de puertas debe de ser mayor a 0");
                numeroPuertas = value;
            }
        }

        //Constructor
        public Auto(string marca, string modelo, int anio, int numeroPuertas)
            : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        //Comportamiento
        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo un Auto: {base.MostrarInformacion()} " +
                $"y con un Numero De Puertas: {NumeroPuertas} ");
        }
    }
}
