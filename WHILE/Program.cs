namespace WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION DE VARIABLES
            int Tabla, Cont = 10;

            Console.Write("Ingrese una tabla de multiplicar a mostrar -> ");
            Tabla = Convert.ToInt32(Console.ReadLine());


            // OPCION 1
            while (Cont >= 1)
            {
                Console.WriteLine($"{Tabla} X {Cont} = {Tabla * Cont}");
                Cont--;
            }


            // OPCION 2
            /*while (true)
            {
                Console.WriteLine($"{Tabla} X {Cont} = {Tabla * Cont}");

                Cont++;

                if (Cont > 10)
                {
                    break;
                }
            }*/
        }
    }
}