using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_9
{
    public class C_TablaMulti
    {
        public C_TablaMulti() {
            Numero = 0;
            Multiplicador = 0;
        
        
        }
        public int Numero;
        public int Multiplicador;
        public void Multiplicar()
        {
            do
            {
                Console.WriteLine("Introdusca su numero, introdusca -1 para cerrar el programa");
                Numero = int.Parse(Console.ReadLine());
                for (Multiplicador = 1; Multiplicador <= 12; Multiplicador++)
                {
                    Console.WriteLine(Numero + "*" + Multiplicador + "=" + Numero * Multiplicador + "\n");

                }
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                Console.Clear();
            } while (Numero != -1);
        }

    }
}
