using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_HUERTA_MADUEÑO_OSCAR_ABRAHAM
{
    class Metodo //Se crea la clase "Metodo"
    {
        public static void Quick_Sort(double[] Num, int izq, int der) //Asignacion de variables dentro del void QuickSort
        {
            if (izq < der) //Acomodo de los digitos
            {
                int aux = Particion(Num, izq, der);

                if (aux > 1)
                {
                    Quick_Sort(Num, izq, aux - 1);
                }
                if (aux + 1 < der)
                {
                    Quick_Sort(Num, aux + 1, der);
                }
            }

        }

        public static int Particion(double[] Num, int izq, int der) //Aplicacion del metodo
        {
            double aux = Num[izq];
            while (true)
            {

                while (Num[izq] < aux)
                {
                    izq++;
                }

                while (Num[der] > aux)
                {
                    der--;
                }

                if (izq < der)
                {
                    if (Num[izq] == Num[der]) return der;

                    double aux2 = Num[izq];
                    Num[izq] = Num[der];
                    Num[der] = aux2;

                }
                else
                {
                    return der;
                }
            }
        }

    }
}
