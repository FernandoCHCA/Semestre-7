namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************\n");
            Console.Write("Ingrese su nombre porfavor -> ");
            string Nombre = Console.ReadLine();
            Console.Write("Ingrese su edad porfavor -> ");
            string inputEdad = Console.ReadLine();
            int Edad = int.Parse(inputEdad);
            Console.Write("Ingrese su dirección porfavor -> ");
            string Direccion = Console.ReadLine();

            Console.WriteLine("\n**************************************************************\n");
            Console.WriteLine("Perfecto! Muchas gracias por haber ingreso los datos requeridos" +
                "\nA continuacion se presentara la información obtenida.");
            Console.WriteLine($"\nTu nombre es {Nombre}");
            Console.WriteLine($"Tu edad es {Edad}");
            Console.WriteLine($"Tu dirección es {Direccion}");
            Console.WriteLine("**************************************************************");
        }
    }
}