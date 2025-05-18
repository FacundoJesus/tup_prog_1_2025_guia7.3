namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor, acumulador, nGrupoMayorPromedio, nGrupoMenorPromedio;
            double promedio, mayorPromedio, menorPromedio;

            //Iterar 4 grupos
            mayorPromedio = 0;
            menorPromedio=0;
            nGrupoMayorPromedio = 0;
            nGrupoMenorPromedio = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Grupo: Nº"+i);

                //Iterar seis valores
                acumulador = 0;
                for (int j = 1; j <= 6; j++)
                {
                    Console.WriteLine($"Ingrese el {j}º valor obtenido:");
                    valor = Convert.ToInt32(Console.ReadLine());
                    acumulador += valor;
                }

                promedio = (acumulador * 1.0) / 6;
                Console.WriteLine($"Promedio: {promedio:f2}");

                if (i == 1)
                {
                    mayorPromedio = promedio;
                    nGrupoMayorPromedio = i;
                    menorPromedio = promedio;
                    nGrupoMenorPromedio = i;
                }

                if (promedio > mayorPromedio) {
                    mayorPromedio = promedio;
                    nGrupoMayorPromedio = i;
                }
                if (promedio < menorPromedio)
                {
                    menorPromedio = promedio;
                    nGrupoMenorPromedio = i;
                }
            }
            Console.WriteLine($"Nº Grupo con Mayor Promedio: {nGrupoMayorPromedio}, Mayor Promedio: {mayorPromedio:f2}");
            Console.WriteLine($"Nº Grupo con Menor Promedio: {nGrupoMenorPromedio}, Menor Promedio: {menorPromedio:f2}");
        }
    }
}
