using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para guardar cuatro numeros digitados por el teclado y luego mostrar su media y los numeros digitados");

            int[] Numeros = new int[4];
            float N = 0;
            Console.WriteLine("Presione cualquier tecla para continuar ");
            Console.ReadKey();
            Console.Clear();


            for (int i = 0; i <= 3; i++)
            {
                int M = 1 + i;
                Console.WriteLine("Digite el numero {0} ", M);
                Numeros[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();



            }
            for (int i = 0; i <= 3; i++)
            {
                N = N + Numeros[i];
            }
            N /= 4;
            Console.WriteLine("La media aritmetica es: " + N);
            
            for (int i = 0; i <= 3; i++)
            {
                int M = 1 + i;
                Console.WriteLine("[" + Numeros[i] + "] " +   " Este es el numero " + M);
            }




        }
    }
}
