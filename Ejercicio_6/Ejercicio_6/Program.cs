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
        //Method


        public void Name()
        {
            if (i <= 0) { 
            Nombre = new string[700];
}
           
            Console.WriteLine("Nombre de la Imagen");

            Nombre[i] = Console.ReadLine();
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
        public void Peso ()
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
            Console.WriteLine("Especifique el espacio de su imagen '1-700' ");

            i = int.Parse(Console.ReadLine());
            i--;
            Console.WriteLine("Nombre:\n " +Nombre[i]);
            Console.WriteLine("Ancho:\n " +AnPixeles[i] + "Px");
            Console.WriteLine("Alto:\n " +AlPixeles[i] + "Px");
            Console.WriteLine("Peso:\n " + TaKB[i] + "KB");


        }

        static void Main(string[] args)

        {
            string p = "";
            Program obj = new Program();
            int c = 0;
            int z = 0;
            do
            {
                do
                {
                    do {
                        Console.WriteLine("Digite el numero de su imagen ");
                        i = int.Parse(Console.ReadLine());
                        i--;
                        z = i - c;
                        int P = 700 - c;
                        Console.Clear();
                        Console.WriteLine("Quedan {0} espacios disponibles ", P);
                        if (z < 0)
                            
                            Console.WriteLine("Escoja otro espacio, este esta lleno");
                            


                        
                    } while (z < 0);

                   obj.Name();
                    obj.Ancho();
                    obj.Alto();
                    obj.Peso();
                    

                    Console.WriteLine("Presione (s) para incluir datos de otra imagen (n) para ver los datos hasta el momento ");
                    c++;
                    
                    p = Console.ReadLine();
                    Console.Clear();
                } while (p != "n");
                int q = 0;
                do
                {
                    
                    obj.VerNombre();

                    q = int.Parse(Console.ReadLine());
                } while (q != 0);
                Console.WriteLine(" Presione (s) para continuar o (n) para concluir ");
                p = Console.ReadLine();
                
            } while (p != "n");

           
        }
    }
}
