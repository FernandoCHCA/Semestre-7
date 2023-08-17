namespace FORIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION DE VARIABLES
            int Tabla;
            
            Console.Write("Ingrese una tabla de multiplicar a mostrar -> ");
            Tabla = Convert.ToInt32(Console.ReadLine());

            for (int Cont = 10; Cont >= 1; Cont--)
            {
                Console.WriteLine($"{Tabla} X {Cont} = {Tabla * Cont}");
            }
        }
    }
}