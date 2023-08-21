namespace EjClase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION DE VARIABLES
            string Nombre, ApellidoM, ApellidoP;
            Boolean RNombre, RApellidoM, RApellidoP;

            Console.Write("Ingrese su(s) nombre(s): ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido materno: ");
            ApellidoM = Console.ReadLine();
            Console.Write("Ingrese su apellido paterno: ");
            ApellidoP = Console.ReadLine();

           
            RNombre = Validadon(Nombre);
            RApellidoM = Validadon(ApellidoM);
            RApellidoP = Validadon(ApellidoP);

            if (!RNombre && !RApellidoM && !RApellidoP)
            {
                Console.WriteLine("Se guardo el registro correctamente");
            }
            else
            {
                Console.WriteLine("Listado de errores");
                if (RNombre)
                {
                    Console.WriteLine("Revise el Nombre");
                }
                if (RApellidoM)
                {
                    Console.WriteLine("Revise el Apellido Materno");
                }
                if (RApellidoP)
                {
                    Console.WriteLine("Revise el Apellido Paterno");
                }
            }

        }

        static Boolean Validadon(string PTexto)
        {
            Boolean Result = false;

            foreach(char Letra in PTexto.Replace(" ", ""))
            {
                if (!char.IsLetter(Letra))
                {
                    Result = true;
                    break;
                }
            }

            return Result;
        }

    }
}