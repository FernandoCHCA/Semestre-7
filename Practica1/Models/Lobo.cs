using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Models
{
    internal class Lobo : Carnivoro
    {
        //public string ColorCabello { get; set; }
        private int VelocidadPorDefecto = 20;

        // CONSTRUCTOR
        public Lobo() 
        {
            if (this.Nombre == null/* || this.Nombre.Equals("")*/)
            {
                this.Nombre = "Lobo";
                Console.WriteLine($"El nombre del animal es: {this.Nombre}");
                Console.WriteLine("Se cargo los datos a la base de datos - SIN PARAMETROS");
            }
        }

        public Lobo(string Nombre)// : this()
        {
            this.Nombre = Nombre;
            //if (this.Nombre != null && !this.Nombre.Equals(""))
            if (!string.IsNullOrEmpty(this.Nombre))
            {
                Console.WriteLine($"El nombre del animal es: {this.Nombre}");
                Console.WriteLine("Se cargo los datos a la base de datos - CON PARAMETROS");
            }
        }

        public void Correr()
        {
            Console.WriteLine($"Corriendo a una velocidad de: {VelocidadPorDefecto}");
        }

        public void Correr(int velocidad)
        {
            Console.WriteLine($"Corriendo a una velocidad de: {velocidad}");
        }

        public void Correr(int velocidad, string detalle)
        {
            Console.WriteLine($"Corriendo a una velocidad de: {velocidad} y {detalle}");
        }

        public void Correr(string detalle)
        {
            Console.WriteLine($"Corriendo: {detalle}");
        }
    }
}
