using ClasesObjetos.Models;

namespace ClasesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Actividad 1
            // HACIENDO USO DE LAS CLASES Y MANDANDO A LLAMAR LOS METODOS
            Cerveza oCerveza = new Cerveza(5, 6.5M, 30);
            oCerveza.Fermentacion();
        }
    }
}