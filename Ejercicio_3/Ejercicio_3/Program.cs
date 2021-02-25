using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Programa desarrollado por Ramces Batista Peña para mostrar los meses y la cantidad de dias que poseen ");

                int[] Meses  = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            string[] Mes = {"Enero", "Febrero", "Marzo", "Abri", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                Console.Clear();
            int M = 0;
            Console.WriteLine("Escriba el numero de su mes, esto tomando en cuenta ue enero es el mes 1  ");
            M = Convert.ToInt32(Console.ReadLine());
            int SE = M - 1;
            Console.WriteLine("Mes seleccionado es: \n{0}\nEste mes tiene: \n{1} dias ",Mes[SE], Meses[SE]);





                

            }
    }
}
