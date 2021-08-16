using System;
namespace Arreglo
{
    class Arreglo
    {
        int[] edades;
        int suma = 0;
        public void recibe()
        {
            edades = new int[10];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write("Ingrese la edad: " + (i + 1) + ": ");
                edades[i] = int.Parse(Console.ReadLine());
                suma += edades[i];
            }
            Console.Write("\nCalculando el promedio... ");
            //INGRESA AQUÍ TU CÓDIGO
            Console.Write("\n");
            Console.Write("\nEl total de las edades es: " + suma);

        }

        static void Main(string[] args)
        {
            Arreglo alumnos = new Arreglo();
            alumnos.recibe();
            Console.ReadKey();
        }
    }
}
