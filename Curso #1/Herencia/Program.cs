using Herencia.Models;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Actividad 2
            // HACIENDO USO DE LA HERENCIA DE LAS CLASES, TODO LO QUE TRAIGA EL PADRE LO TENDRÁ, INCLUSO SI TIENE HEREDADO DE ALGUIEN MAS, LO TENDRA TAMBIEN
            Lobo oLobo = new Lobo();
            oLobo.Correr();
            oLobo.Nombre = "Rimuru";

            Buitre oBuitre = new Buitre();
            oBuitre.Vuela();
            oBuitre.Nombre = "Manito";

            Console.WriteLine(oLobo.Nombre);
            Console.WriteLine(oBuitre.Nombre);
        }
    }
}