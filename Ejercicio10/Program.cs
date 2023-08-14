namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************\n");
            Console.WriteLine("Bienvenido al programa!");
            Console.Write("\nIngrese el area del circulo -> ");
            string inputRadio = Console.ReadLine();
            int Radio = int.Parse(inputRadio);
            Console.WriteLine("\n******************************************\n");

            double Area = 3.14159 * (Radio * Radio);

            Console.WriteLine($"El Area de un Circulo con un radio de {Radio} es el siguiente: {Area}");
        }
    }
}