namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opinion, encuestados, opinion1, opinion2, opinion3;
            double prcop1, prcop2, prcop3;

            Console.WriteLine("Ingrese la opinion: (0-Positivo / 1-Negativo / 2-Indeciso)(-1 P/FINALIZAR)");
            opinion = Convert.ToInt32(Console.ReadLine());

            encuestados = 0;
            opinion1 = 0;
            opinion2 = 0;
            opinion3 = 0;

            while (opinion != -1)
            {
                switch (opinion)
                {
                    case 0:
                        opinion1++;
                        break;
                    case 1:
                        opinion2++;
                        break;
                    case 2:
                        opinion3++;
                        break;
                    default:
                        Console.WriteLine("Opinión no válida");
                        break;
                }
                if ( opinion >=0 && opinion <=2)
                {
                    encuestados++;
                }
                
                Console.WriteLine("Ingrese la opinion: (0-Positivo / 1-Negativo / 2-Indeciso) (-1 P/FINALIZAR)");
                opinion = Convert.ToInt32(Console.ReadLine());
            }

            if (encuestados > 0)
            {
                prcop1 = (opinion1 * 1.0 / encuestados) * 100;
                prcop2 = (opinion2 * 1.0 / encuestados) * 100;
                prcop3 = (opinion3 * 1.0 / encuestados) * 100;

                Console.WriteLine($"Cantidad de encuestados: {encuestados}");
                Console.WriteLine($"Porcentaje de Positivos: {prcop1:f0}%");
                Console.WriteLine($"Porcentaje de Negativos: {prcop2:f0}%");
                Console.WriteLine($"Porcentaje de Indecisos: {prcop3:f0}%");
            }
            else
            {
                Console.WriteLine("No hubo encuestados.");
            }








        }
    }
}
