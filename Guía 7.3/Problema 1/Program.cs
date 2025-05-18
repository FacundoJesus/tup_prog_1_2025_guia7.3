namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jugadores; 
            double monto, montoMayor, montoMenor;
            string nombre, nombreMayor, nombreMenor;

            Console.WriteLine("Ingrese la cantidad de Jugadores:");
            jugadores = Convert.ToInt32(Console.ReadLine());

            montoMayor = 0;
            montoMenor = 0;
            nombreMayor = "";
            nombreMenor = "";
            for (int i = 1; i <= jugadores; i++)
            {

                Console.WriteLine($"Ingrese el nombre del {i}º Jugador:");
                nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese el monto del {i}º Jugador:");
                monto = Convert.ToDouble(Console.ReadLine());


                if (i == 1)
                {
                    nombreMayor = nombre;
                    montoMayor = monto;
                    nombreMenor = nombre;
                    montoMenor = monto;
                }

                if (monto > montoMayor)
                {
                    montoMayor = monto;
                    nombreMayor = nombre;
                }
                if (monto < montoMenor)
                {
                    montoMenor = monto;
                    nombreMenor = nombre;
                }
            }
            Console.WriteLine($"Nombre del Jugador con mayor monto: {nombreMayor} , Mayor Monto: {montoMayor:f2}");
            Console.WriteLine($"Nombre del Jugador con menor monto: {nombreMenor} , Menor Monto: {montoMenor:f2}");
        }
    }
}
