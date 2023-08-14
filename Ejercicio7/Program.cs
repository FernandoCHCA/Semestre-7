namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************\n");
            Console.WriteLine("Bienvenido al programa!");
            Console.Write("\nIngrese un un digito que quiera convertir al cuadrado -> ");
            string inputNumero = Console.ReadLine();
            int Numero = int.Parse(inputNumero);
            Console.WriteLine("\n******************************************\n");

            int Cuadrado = Numero * Numero;

            Console.WriteLine($"El Cuadrado del numero {Numero} es el siguiente: {Cuadrado}");
        }
    }
}