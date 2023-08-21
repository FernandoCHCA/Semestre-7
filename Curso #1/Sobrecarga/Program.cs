using Sobrecarga.Models;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Actividad 3
            // HACIENDO USO DE LA SOBRECARGA, SE PUEDEN CREAR DOS METODOS CON EL MISMO NOMBRE,
            // UNO CON UN VALOR POR DEFECTO Y OTRO ESPERANDO UN PARAMETRO,
            // SI NO SE PONE NINGUN PARAMETRO SE USARA EL VALOR POR DEFECTO,
            // PERO SI INSERTA UN PARAMETRO SE USARA DICHO METODO CON EL QUE ACEPTA EL PARAMETRO
            // PERO NO UNICAMENTE CON 2 METODOS, SE PUEDEN MAS,
            // DEPENDIENDO LOS PARAMETROS QUE SE INSERTEN O NO SE INSERTEN Y EL TIPO DE DATO DEL PARAMETRO
            Lobo oLobo = new Lobo("Fernando");
            oLobo.Correr("Solin");

            //Console.WriteLine(oLobo.Nombre);
            //Console.WriteLine(oBuitre.Nombre);
        }
    }
}