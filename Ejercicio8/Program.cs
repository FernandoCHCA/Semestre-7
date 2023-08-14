namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************\n");
            Console.WriteLine("Bienvenido al programa!");
            Console.Write("\nIngrese un lado de un cuadrado para sacar el area de dicho cuadrado -> ");
            string inputNumero = Console.ReadLine();
            int Numero = int.Parse(inputNumero);
            Console.WriteLine("\n******************************************\n");

            int Area = Numero * Numero;

            Console.WriteLine($"El Area de un Cuadrado con lado {Numero} es el siguiente: {Area}");
        }
    }
}