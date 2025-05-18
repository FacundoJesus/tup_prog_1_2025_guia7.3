namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            double acumulador,promedio;


            acumulador = 0;
            for (i = 1; i <= 3; i ++) {
                Console.WriteLine("Ingrese un número:");
                num = Convert.ToInt32(Console.ReadLine());
                acumulador += num;
            }
            
            promedio = (acumulador) / (i-1);
            Console.WriteLine($"El promedio de los 20 números es: {promedio:f2}");
        }
    }
}
