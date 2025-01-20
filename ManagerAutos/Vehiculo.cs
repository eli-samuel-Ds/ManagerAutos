using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerAutos
{
    abstract class Vehiculo
    {
        // Atributos privados
        private string marca;
        private string modelo;
        private int anio;

        // Propiedades
        public string Marca
        {
            get => marca;
            set => marca = value;
        }
        public string Modelo
        {
            get => modelo;
            set => modelo = value;
        }
        public int Anio
        {
            get => anio;
            set
            {
                if (value < 1886)
                    throw new ArgumentException("El año no puede ser menor que 1886.");
                anio = value;
            }
        }

        // Constructor
        protected Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        // Método abstracto
        public abstract void Conducir();

        // Método no abstracto
        public string MostrarInformacion()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}";
        }
    }
}