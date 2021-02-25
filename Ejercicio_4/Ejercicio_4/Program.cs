using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para almacenar 10 valores numericos reales y decir cual es el mas grande ");
            float[] Numeros = new float[10];
            Console.WriteLine("Presione enter para continuar ");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i <= 9; i++)
            {
                int M = 1 + i;
                Console.WriteLine("Digite el numero {0} ", M);
                Numeros[i] = float.Parse(Console.ReadLine());
                Console.Clear();

            }

            for (int i = 0; i <= 9; i++)
            {
                float p = Numeros[i];
                int z = 0;
                for (int e = 0; e <= 9; e++)
                {
                    if (p - Numeros[e] >= 0)
                    {
                        z++;
                    }
                }

                if (z == 10)
                {
                    Console.WriteLine("El numero mayor es: " + Numeros[i]);
                    for (int q = 0; q <= 9; q++)
                    {
                        int M = 1 + q;
                        Console.WriteLine("El numero {0} es [{1}]", M, Numeros[q]);

                    }
                    Console.ReadKey();
                    Console.Clear();


                }

            }
        }

    }
}
