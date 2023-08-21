using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2Clase1.Models
{
    public class DtoCliente
    {
        protected string Nombre { get; set; }
        protected string APaterno { get; set; }
        protected string AMaterno { get; set; }
        public Boolean DatosIngresados { get; set; }

        // CONSTRUCTOR
        public DtoCliente() 
        {
            if (this.Nombre == null && this.APaterno == null && this.AMaterno == null)/* || this.Nombre.Equals("")*/
            {
                DatosIngresados = false;
                Console.WriteLine("\nAlgun dato esta nulo, vuelva a revisarlo porfavor!");
                Console.WriteLine("\n*********************************************************\n");
            }
        }

        public DtoCliente(string Nombre,string APaterno, string AMaterno)// : this()
        {
            this.Nombre = Nombre.Replace(" ", "");
            this.APaterno = APaterno.Replace(" ", "");
            this.AMaterno = AMaterno.Replace(" ", "");
            //if (this.Nombre != null && !this.Nombre.Equals(""))
            if (!string.IsNullOrEmpty(this.Nombre) && (!string.IsNullOrEmpty(this.APaterno)) && (!string.IsNullOrEmpty(this.AMaterno)))
            {
                DatosIngresados = true;
                Console.WriteLine("\nSe cargo correctamente su Nombre Completo, puede avanzar");
                Console.WriteLine("\n*********************************************************\n");
            }
            else if (this.Nombre == "" || this.APaterno == "" || this.AMaterno == "")
            {
                DatosIngresados = false;
                Console.WriteLine("\nAlgun dato esta vacio, vuelva a revisarlo porfavor!");
                Console.WriteLine("\n*********************************************************\n");
            }
        }
    }
}
