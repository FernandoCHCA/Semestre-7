namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************\n");
            Console.WriteLine("Bienvenido al programa!");
            Console.Write("\nIngrese un primer digito -> ");
            string inputPrimerNumero = Console.ReadLine();
            int PrimerNumero = int.Parse(inputPrimerNumero);
            Console.Write("\nIngrese un segundo digito -> ");
            string inputSegundoNumero = Console.ReadLine();
            int SegundoNumero = int.Parse(inputSegundoNumero);
            Console.WriteLine("\n******************************************\n");

            int Multiplicacion = PrimerNumero * SegundoNumero;

            Console.WriteLine($"La Resultado de la Multiplicacion es el siguiente: {Multiplicacion}");
        }
    }
}