namespace PROCEDIMIENTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;

            Console.Write("Ingrese un numero: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Suma(Num1,Num2);
            Division(Num1, Num2);
        }

        static void Suma(int PNum1, int PNum2)
        {
            //Suma
            Console.WriteLine($"La Suma es: {PNum1 + PNum2}");
        }

        static void Resta(int PNum1, int PNum2)
        {
            //Resta
            Console.WriteLine($"La Resta es: {PNum1 - PNum2}");
        }

        static void Multiplicacion(int PNum1, int PNum2)
        {
            //Multiplicacion
            Console.WriteLine($"La Multiplicacion es: {PNum1 * PNum2}");
        }

        static void Division(int PNum1, int PNum2)
        {
            //Division
            Console.WriteLine($"La Division es: {PNum1 / PNum2}");
        }
    }
}