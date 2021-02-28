using System;

namespace Ejercicio_6
{
    class Program
    {
        //Arrays
        private string[] Nombre;
        private int[] AnPixeles;
        private int[] AlPixeles;
        private float[] TaKB;


        //Declarando variable global 
        static int i = 0;
        static int c = 0;
        static int ConEjec = 0;

        //Method


        public void Name()
        {
            if (i <= 0)
            {
                Nombre = new string[700];
            }
            Console.WriteLine("Nombre de la Imagen");

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


            c++;

        }

        public void Ancho()
        {
            if (i <= 0)
            {
                AnPixeles = new int[700];
            }
            Console.WriteLine("Ancho de la Imagen en pixeles");
            AnPixeles[i] = int.Parse(Console.ReadLine());
        }

        public void Alto()
        {
            if (i <= 0)
            {
                AlPixeles = new int[700];
            }
            Console.WriteLine("Alto de la Imagen en pixeles");
            AlPixeles[i] = int.Parse(Console.ReadLine());
        }
        public void Peso()
        {
            if (i <= 0)
            {
                TaKB = new float[700];
            }
            Console.WriteLine("Peso de la Imagen en KB");
            TaKB[i] = int.Parse(Console.ReadLine());
        }
        public void VerNombre()
        {
            Console.WriteLine("Fichero [{0}]", i);
            i--;
            Console.WriteLine("Nombre:\n " + Nombre[i]);
            Console.WriteLine("Ancho:\n " + AnPixeles[i] + "Px");
            Console.WriteLine("Alto:\n " + AlPixeles[i] + "Px");
            Console.WriteLine("Peso:\n " + TaKB[0] + "KB");
            Console.WriteLine("Presione enter para volver al menu principal ");
            Console.ReadKey();
            Console.Clear();
        }
        public void BuscarNombre()
        {
            String BusNombre = "";
            Console.WriteLine("Escriba el nombre de su fichero: ");
            BusNombre = Console.ReadLine();
            i = -1;
            do
            {
                i++;
            } while (BusNombre != Nombre[i]);
            i++;
            VerNombre();
        }
        public void Chequeador()
        {
            do
            {
                int P = 700 - c;
                Console.WriteLine("Quedan {0} espacios disponibles ", P);
                Console.WriteLine("Digite el numero de su imagen ");
                i = int.Parse(Console.ReadLine());
                i--;
                Console.Clear();
                if (TaKB[i] > 0)
                {
                    Console.WriteLine("Escoja otro espacio, este esta lleno");
                }
            } while (TaKB[i] > 0);
        }

        public void Primer()
        {

            if (TaKB[i] == 0)
            {
                Console.WriteLine("Bienvenido, como es es su primera vez el programa esta vacio, indique los datos de su primera imegen: ");
                Name();
                Ancho();
                Alto();
                Peso();
            }

        }

        public void inicializador() {
            if (ConEjec == 1)
            { 
                Nombre = new string[700];
                AnPixeles = new int[700];
                AlPixeles = new int[700];
                TaKB = new float[700];
            }
        }

        public void VerFichero() {
            Console.WriteLine("Los Ficheros Son: ");
            for (i = 1; i <= c; i++)
            {
                Console.WriteLine("Fichero [{0}]", i);
                i--;
                Console.WriteLine("Nombre:\n " + Nombre[i]);
                i++;
            }
        }
        static void Main(string[] args)
        {
            string p = "";
            Program obj = new Program();
            int y = 0;

            do{
                ConEjec++;
                if (i <= 0)
                {
                    obj.inicializador();
 
                    obj.Primer();
                    Console.Clear();
                }

                Console.WriteLine(" ______________________________________________\n");
                Console.WriteLine(" |               Menu Principal                |\n");
                Console.WriteLine(" |_____________________________________________|\n");
                Console.WriteLine(" | 1 - Introducir una ficha nueva              |\n");
                Console.WriteLine(" | 2 - Ver fichas                              |\n");
                Console.WriteLine(" | 3 - Buscar la ficha                         |\n ");
                Console.WriteLine(" | 4 - Cerrar programa                         |\n ");
                Console.WriteLine(" |_____________________________________________|\n");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (y)
                {
                    case 1:
                        do
                        {
                            obj.Chequeador();
                            obj.Name();
                            obj.Ancho();
                            obj.Alto();
                            obj.Peso();
                            Console.WriteLine("Presione (s) para incluir datos de otra imagen (n) para volver al menu principal ");
                            p = Console.ReadLine();
                            Console.Clear();
                        } while (p != "n");
                        break;

                    case 2:
                        obj.VerFichero();
                        break;

                    case 3:
                        obj.BuscarNombre();
                        break;

                    case 4:
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
            }while (y != 4);           
        }
    }
}
