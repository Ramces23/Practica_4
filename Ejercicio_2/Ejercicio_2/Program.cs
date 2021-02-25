using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Programa desarrollado por Ramces Batista Peña para guardar cinco numeros y mostrarlos en orden contrario");

                float[] Numeros = new float[5];
                Console.WriteLine("Presione cualquier tecla para continuar ");
                Console.ReadKey();
                Console.Clear();


                for (int i = 0; i <= 4; i++)
                {
                    int M = 1 + i;
                    Console.WriteLine("Digite el numero {0} ", M);
                    Numeros[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();



                }
          

                for (int i = 4; i >= 0; i--)
                {
                    int M = 1 + i;
                    Console.WriteLine("[" + Numeros[i] + "] " + " Este es el numero " + M);
                }

            }
        }
}
