namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, menor, mayor;
            Console.WriteLine("Ingrese el 1° número: o -1 P/SALIR");
            num = Convert.ToInt32(Console.ReadLine());

            i = 0;
            menor = 0;
            mayor = 0;
            while (num != -1)
            {
                i++;
                if (i == 1)
                {
                    menor = num;
                    mayor = num;
                }

                if (num > mayor) 
                {
                    mayor = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
                Console.WriteLine("Ingrese el siguiente número o -1 P/SALIR");
                num = Convert.ToInt32(Console.ReadLine());
            }
            
            if (i > 0) {
                Console.WriteLine("Cantidad de números ingresados: " + i);
                Console.WriteLine("Mayor número:" + mayor);
                Console.WriteLine("Menor número:" + menor);

            }
            else
            {
                Console.WriteLine("No hubo números ingresados");
            }
        }
    }
}
