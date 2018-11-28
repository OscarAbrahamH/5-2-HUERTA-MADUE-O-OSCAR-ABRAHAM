using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _5_2_HUERTA_MADUEÑO_OSCAR_ABRAHAM;

namespace Quick_Sort
{
    class CLASE //Nombre de la clase
    {
     
        static void Main(string[] args)
        {

            double Raiz = Math.Sqrt(3); //Aplica Raiz Cuadrada al 3

            //figura1 = Lista 1, figura2 = Lista 2, figura3 = Lista 3, figura4 = Lista 4
            double[] figura1 = new double[] { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 }; //Datos 1 
            double[] figura2 = new double[] { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 }; //Datos 2
            double[] figura3 = new double[] { 3, 7, 15, (4 / 3), 155, 100, 15, Raiz, 5, 2, 3, 2 }; //Datos 3
            double[] figura4 = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 }; //Datos 4

            //------------1-----------------
            Console.WriteLine("-> Original 1: ");
            foreach (var num in figura1) //Impresion de los datos "figura 1" sin acomodar
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Metodo.Quick_Sort(figura1, 0, figura1.Length - 1);

            Console.WriteLine();
            Console.WriteLine("-> Menor a mayor 1: ");

            foreach (var num in figura1) //Impresion de los datos "figura 1" ya aplicando el metodo QuickSort
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");

            //------------2-----------------
            Console.WriteLine("-> Original 2: ");
            foreach (var num in figura2) //Impresion de los datos "figura 2" sin acomodar
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Metodo.Quick_Sort(figura2, 0, figura2.Length - 1);
            Console.WriteLine();
            Console.WriteLine("-> Menor a mayor 2: ");
            foreach (var num in figura2) //Impresion de los datos "figura 2" ya aplicando el metodo QuickSort
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");

            //------------3-----------------
            Console.WriteLine("-> Original 3: ");
            foreach (var num in figura3) //Impresion de los datos "figura 3" sin acomodar
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Metodo.Quick_Sort(figura3, 0, figura3.Length - 1);
            Console.WriteLine();
            Console.WriteLine("-> Menor a mayor 3: ");
            foreach (var num in figura3) //Impresion de los datos "figura 3" ya aplicando el metodo QuickSort
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");

            //------------4-----------------
            Console.WriteLine("-> Original 4: ");
            foreach (var num in figura4) //Impresion de los datos "figura 4" sin acomodar
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Metodo.Quick_Sort(figura4, 0, figura4.Length - 1);
            Console.WriteLine();
            Console.WriteLine("-> Menor a mayor 4: ");
            foreach (var num in figura4) //Impresion de los datos "figura 4" ya aplicando el metodo QuickSort
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
