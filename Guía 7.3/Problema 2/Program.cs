namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alumnos, nota, notaMayor, notaMenor;
            string nombre, nombreMayor, nombreMenor;

            Console.WriteLine("Ingrese la cantidad de alumnos:");
            alumnos = Convert.ToInt32(Console.ReadLine());

            notaMayor = 0;
            notaMenor = 0;
            nombreMayor = "";
            nombreMenor = "";
            for (int i = 1; i <= alumnos; i++) {

                Console.WriteLine($"Ingrese el nombre del {i}º alumno:");
                nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese la nota del {i}º alumno:");
                nota = Convert.ToInt32(Console.ReadLine());

                
                if ( i == 1 ) {
                    nombreMayor = nombre;
                    notaMayor = nota;
                    nombreMenor = nombre;
                    notaMenor = nota;
                }

                if (nota > notaMayor) {
                    notaMayor = nota;
                    nombreMayor = nombre;
                }
                if (nota < notaMenor)
                {
                    notaMenor = nota;
                    nombreMenor = nombre;
                }
            }
            Console.WriteLine($"Nombre del Alumno con mayor nota: {nombreMayor} , Mayor Nota: {notaMayor}");
            Console.WriteLine($"Nombre del Alumno con menor nota: {nombreMenor} , Menor Nota: {notaMenor}");
        }
    }
}
