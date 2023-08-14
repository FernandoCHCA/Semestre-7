namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************\n");
            Console.WriteLine("Bienvenido al programa!");
            Console.Write("\nIngrese la longitud de un lado de un cuadrado para calcular su perimetro -> ");
            string inputNumero = Console.ReadLine();
            int Numero = int.Parse(inputNumero);
            Console.WriteLine("\n******************************************\n");

            int Perimetro = Numero * 4;

            Console.WriteLine($"El Perimetro de un Cuadrado con un lado de {Numero} es el siguiente: {Perimetro}");
        }
    }
}