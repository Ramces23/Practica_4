using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para almacenar nombres y mostrarlos en una lista ");
            string[] Nombres = new string[100];
            Console.WriteLine("Escriba sus nombres y presione enter en blanco para concluir ");
            int i = -1;

            do
            {
                i++;
                Nombres[i] = Console.ReadLine();
            } while (Nombres[i].Length !=0 );

            Console.Clear();
            Console.WriteLine("Estos son los nombres: ");
            i = -1;

            do
            {
                i++;
                Console.WriteLine(Nombres[i]);
            } while (Nombres[i].Length != 0);
        }
    }
}
