using System;

namespace Programa_recopilatorio_de_soluciones_matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa recopilatorio de sulociones matematicas creado por Ramces Batista Peña");

            Console.WriteLine(" Escoja el programa que quiere usar");

            Console.WriteLine("1 Area de un triangulo");

            Console.WriteLine("2 Ecuaciones cuadraticas");

            Console.WriteLine("3 Binomio cuadrado perfecto");

            Console.WriteLine("4 Raiz cuadrada");
            int E = 0;
            E = Convert.ToInt32(Console.ReadLine());
            switch(E) 
            {
                case 1:
                    Console.WriteLine("Digite los valores de la base y la altura de su triangulo");

                    int B = 0;
                    int H = 0;
                    B = Convert.ToInt32(Console.ReadLine());
                    H = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("su resultado es: "  +  ((B * H) / 2));


                    break;
                case 2:




                    break;
                case 3:




                    break;
                case 4:
                    break;








            }
            
        }
    }
}
