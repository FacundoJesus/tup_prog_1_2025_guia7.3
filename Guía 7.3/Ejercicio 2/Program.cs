namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            double acumulador, i, promedio;

            Console.WriteLine("Ingrese el 1° número o Presione -1 P/Salir");
            num = Convert.ToInt32(Console.ReadLine());
            i = 0;
            acumulador = 0;
            while (num != -1)
            {
                acumulador += num;
                i++;
                Console.WriteLine("Ingrese el siguiente número o Presione -1 P/Salir");
                num = Convert.ToInt32(Console.ReadLine());
            }

            if ( i > 0)
            {
                promedio = acumulador / i;
                Console.WriteLine($"La cantidad de números ingresados fueron: {i} y el promedio es: {promedio:f2}");
            }
            else
            {
                Console.WriteLine("No ingresaste números");
            }

        }
    }
}
