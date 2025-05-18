namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayor, menor, i;

            menor = 0;
            mayor = 0;
            for (i = 1; i <= 3; i++) {
                Console.WriteLine("Ingrese un número:");
                num = Convert.ToInt32(Console.ReadLine());
                if ( i == 1)
                {
                    mayor = num;
                    menor = num;
                }
                if (num < menor) {
                    menor = num;
                }
                if (num > mayor) {
                    mayor = num;
                }
            }
            Console.WriteLine($"Cantidad de números ingresados:{i-1}");
            Console.WriteLine($"Mayor número:{mayor}");
            Console.WriteLine($"Menor número:{menor}");
        }
    }
}
