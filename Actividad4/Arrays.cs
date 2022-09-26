using System;
using System.Linq;

namespace Actividad4
{
    public class Arrays
    {
        static void Main(string[] args)
        {
        }

        public static int minValorArray(int[] array)
        {
            if (array.Length != 0)
            {
                int min = array[0];

                foreach (int i in array)
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }

                return min;
            }
            else {
                return 0;
            }
            
            throw new NotImplementedException();
        }
        public static int[] invertirArray(int[] array)
        {
            if (array.Length != 0)
            {
                Array.Reverse(array);
            }

            return array;

            throw new NotImplementedException();
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {

            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == valor)
                    {
                        return i;
                    }
                }
            }
            
            return -1;
            
            throw new NotImplementedException();
        }

        public static int calcularModa(int[] entrada)
        {
            if (entrada.Length != 0)
            {
                int maxVal = entrada[0], cont = 0, contMax = 0;
                for (int i = 0; i < entrada.Length; i++)
                {

                    for (int j = i + 1; j < entrada.Length - 1; j++)
                    {
                        if (entrada[i] == entrada[j])
                        {
                            cont++;
                        }
                    }

                    if (contMax < cont)
                    {
                        maxVal = entrada[i];
                    }

                    cont = 0;

                }

                return maxVal;
            }
            else {
                return 0;
            }

            throw new NotImplementedException();
        }
    }
}
