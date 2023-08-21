using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento.Models
{
    internal class Lobo : Carnivoro
    {
        public string ColorCabello { get; set; }
        private int VelocidadPorDefecto = 20;

        public override string GetNombre()
        {
            return $"Soy un Lobo llamado: {Nombre}";
        }

        // CONSTRUCTOR
        public Lobo()
        {
            if (this.Nombre == null/* || this.Nombre.Equals("")*/)
            {
                this.Nombre = "Lobo Null";
                Console.WriteLine($"El nombre del animal es: {this.Nombre}");
                Console.WriteLine("No se cargo los datos a la base de datos - ESTA NULL");
                Console.WriteLine("\n********************************************************\n");
            }
        }

        public Lobo(string Nombre)// : this()
        {
            this.Nombre = Nombre;
            //if (this.Nombre != null && !this.Nombre.Equals(""))
            if (!string.IsNullOrEmpty(this.Nombre))
            {
                Console.WriteLine($"El nombre del animal es: Lobo {this.Nombre}");
                Console.WriteLine("Se cargo los datos a la base de datos - CON DATOS");
                Console.WriteLine("\n********************************************************\n");
            }
            else if (this.Nombre == "")
            {
                this.Nombre = "Lobo Vacio";
                Console.WriteLine($"El nombre del animal es: {this.Nombre}");
                Console.WriteLine("No se cargo los datos a la base de datos - ESTA VACIO");
                Console.WriteLine("\n********************************************************\n");
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
