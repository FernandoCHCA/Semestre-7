using Practica1.Models;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Actividad 1
            // HACIENDO USO DE LAS CLASES Y MANDANDO A LLAMAR LOS METODOS
            /*Cerveza oCerveza = new Cerveza(5,6.5M,30);
            oCerveza.Fermentacion();*/


            // Actividad 2
            // HACIENDO USO DE LA HERENCIA DE LAS CLASES, TODO LO QUE TRAIGA EL PADRE LO TENDRÁ, INCLUSO SI TIENE HEREDADO DE ALGUIEN MAS, LO TENDRA TAMBIEN
            /*Lobo oLobo = new Lobo();
            oLobo.Correr();
            oLobo.Nombre = "Rimuru";

            Buitre oBuitre = new Buitre();
            oBuitre.Vuela();
            oBuitre.Nombre = "Manito";

            Console.WriteLine(oLobo.Nombre);
            Console.WriteLine(oBuitre.Nombre);*/


            // Actividad 3
            // HACIENDO USO DE LA SOBRECARGA, SE PUEDEN CREAR DOS METODOS CON EL MISMO NOMBRE, UNO CON UN VALOR POR DEFECTO Y OTRO ESPERANDO UN PARAMETRO,
            // SI NO SE PONE NINGUN PARAMETRO SE USARA EL VALOR POR DEFECTO, PERO SI INSERTA UN PARAMETRO SE USARA DICHO METODO CON EL QUE ACEPTA EL PARAMETRO
            // PERO NO UNICAMENTE CON 2 METODOS, SE PUEDEN MAS, DEPENDIENDO LOS PARAMETROS QUE SE INSERTEN O NO SE INSERTEN Y EL TIPO DE DATO DEL PARAMETRO
            Lobo oLobo = new Lobo(); 
            oLobo.Correr("Felizmente"); 
        }
    }
}