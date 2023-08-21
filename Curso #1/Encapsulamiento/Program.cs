using Encapsulamiento.Models;

namespace Encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lobo oLobo = new Lobo("Fernando");
            //oLobo.Correr("Solin");

            Console.WriteLine(oLobo.GetNombre());
        }
    }
}