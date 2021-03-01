    using System;

namespace Ejercicio_8
{
    class Program
    {
        private float[] Estatura;
        private string[] Nombre;

        static int i = 0;
        static int c = 0;
        static int q = 0;
        static float suma = 0;
        static float promedio = 0;

        public void Name()
        {
            c = i + 1;
            Console.WriteLine("Nombre de la persona {0}", c);
            int Comparar = 0;
            int ConCompa = 0;
            do
            {
                Nombre[i] = Console.ReadLine();
                if (i > 0)
                {
                    ConCompa = 0;
                    for (Comparar = i - 1; Comparar >= 0; Comparar--)
                    {
                        if (Nombre[i] == Nombre[Comparar])
                        {
                            ConCompa++;
                            Console.WriteLine("Ese nombre ya esta en uso, digite otro por favor: ");
                            break;
                        }
                    }
                }
            } while (ConCompa > 0);
        }

        public void Entrada() {
                c = i + 1;
                Console.WriteLine("Digite su altura numero {0}", c);
                Estatura[i] = float.Parse(Console.ReadLine());            
        }
        public void SumProm()
        {
            i = 0;
            suma = 0;
            do
            {
                suma += Estatura[i];
                i++;
            } while (i <= 4);
            promedio = suma / 4;
            Console.WriteLine("Promedio: {0} ", promedio);
        }
        public void inicializador()
        {           
                Nombre = new string[5];
                Estatura= new float[5];
        }
        public void Imprimir() {
            Console.WriteLine("Nombre: {0}\nEstatura: {1} ", Nombre[q], Estatura[q]);
        }
        public void NivelProm() {
            Console.WriteLine("Por encima del promedio: ");
            q = 0;
            do {
                if (Estatura[q] > promedio) {
                    Imprimir();
                }
                q++;
            } while (q!=5);
            Console.WriteLine("Presione enter para continuar ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Por debajo del promedio: ");
            q = 0;
            do
            {
                if (Estatura[q] < promedio)
                {
                    Imprimir();
                }
                q++;
            } while (q != 5);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Programa desarrollado por Ramces Batista Peña para obtener el promedio de varias alturas y decir cuales estan por encima ");
            string p = "";
            do
            {
                Program obj = new Program();
                obj.inicializador();
                do
                {
                    obj.Name();
                    obj.Entrada();
                    i++;
                } while (i != 5);
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                Console.Clear();
                obj.SumProm();
                obj.NivelProm();
                Console.WriteLine("Presione (s) para empezar de nuevo (n) para cerrar el programa ");
                p = Console.ReadLine();
                Console.Clear();
            } while (p != "n");
        }
    }
}
