using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_10
{
   public class C_Datos
    {
        public C_Datos() {
            Nombre = "";
            Edad = 0;                   
        }
        public string Nombre;
        public int Edad;

        public void Menu() {
            int p;

            do
            {

            Console.WriteLine(" ______________________________________________\n");
            Console.WriteLine(" |               Menu Principal                |\n");
            Console.WriteLine(" |_____________________________________________|\n");
            Console.WriteLine(" | 1 - Almacenar datos                         |\n");
            Console.WriteLine(" | 2 - Imprimir datos                          |\n");
            Console.WriteLine(" | 3 - Cerrar programa                         |\n ");
            Console.WriteLine(" |_____________________________________________|\n");
            p = int.Parse(Console.ReadLine());
            Console.Clear();

                switch (p)
                {
                    case 1:
                        Almacenar();
                        Console.WriteLine("\nPresione enter para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Imprimir();
                        Console.WriteLine("\nPresione enter para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Fin del programa\n ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Esta opcion no exite, eliga otra por favor");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            } while (p != 3);
        
        
        }
        public void Almacenar() {
            Console.WriteLine("Introdusca su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introdusca su edad: ");
            Edad = int.Parse(Console.ReadLine());

        }
        public void Imprimir() {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            if (Edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else {
                Console.WriteLine("Usted es menor de edad");
            }



        }

    }
}
