namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************\n");
            Console.WriteLine("Bienvenido al programa!");
            Console.Write("\nIngrese su primera calificación -> ");
            string inputPrimerCalif = Console.ReadLine();
            int PrimerCalif = int.Parse(inputPrimerCalif);
            Console.Write("\nIngrese su segunda calificación -> ");
            string inputSegundaCalif = Console.ReadLine();
            int SegundaCalif = int.Parse(inputSegundaCalif);
            Console.Write("\nIngrese su tercer calificación -> ");
            string inputTercerCalif = Console.ReadLine();
            int TercerCalif = int.Parse(inputTercerCalif);
            Console.WriteLine("\n******************************************\n");

            int Promedio = (PrimerCalif + SegundaCalif + TercerCalif) / 3;

            Console.WriteLine($"El Promedio es el siguiente: {Promedio}");
        }
    }
}