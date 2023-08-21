using Ej2Clase1.Models;
using Ej2Clase1.BL;

namespace Ej2Clase1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese su(s) nombre(s): ");
            string Nombre = Console.ReadLine();

            Console.Write("Ingrese su Apellido Paterno: ");
            string APaterno = Console.ReadLine();

            Console.Write("Ingrese su Apellido Materno: ");
            string AMaterno = Console.ReadLine();

            Console.WriteLine("\n*********************************************************");

            // Creamos el atributo oCliente y Revisamos que contengan datos y no este nulo o vacio
            DtoCliente oCliente = new DtoCliente(Nombre, APaterno, AMaterno);
            BL_Cliente oBLCliente = new BL_Cliente();

            if (oCliente.DatosIngresados == true)
            {
                // Validaremos que sean letras y no numeros o caracteres especiales
                Boolean RNombre = oBLCliente.Validadon(Nombre);
                Boolean RApellidoM = oBLCliente.Validadon(APaterno);
                Boolean RApellidoP = oBLCliente.Validadon(AMaterno);

                oBLCliente.Resultado(RNombre, RApellidoM, RApellidoP);
            }
            else if (oCliente.DatosIngresados == false)
            {
            }

            //List<string> LstValidaciones = BL_Cliente.Validaciones(oCliente);

        }
    }
}