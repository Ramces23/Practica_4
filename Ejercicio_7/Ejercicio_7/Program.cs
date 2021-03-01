using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para separar en letras un nombree introducido");
            string p = "";
            do
            {

                string Nombre = "";
                int n;
                Console.WriteLine("Digite su nombre ");
                Nombre = Console.ReadLine();
                n = Nombre.Length;
                int c = 0;
                char[,] Letra = new char[n, n];
                foreach (char Letras in Nombre)
                {
                    if (c <= n)
                    {
                        Letra[c, 0] = Letras;
                    }
                    c++;
                }
                c = 0;
                do
                {
                    Console.Write("{0} ", Letra[c, 0]);
                    c++;
                } while (c <= n - 1);

                Console.WriteLine("\nPresione enter para continuar ");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Presione (s) para escribir otro nombre (n) para salir ");
                p = Console.ReadLine();
                Console.Clear();
            } while (p != "n");
        }
    }
}