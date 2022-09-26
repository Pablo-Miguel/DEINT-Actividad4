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
                int[] arrayInvertido = new int[array.Length];

                for (int i = arrayInvertido.Length, j = 0; i > 0; i--, j++)
                {
                    arrayInvertido[j] = array[i];
                }

                return arrayInvertido;
            }
            else {
                return array;
            }

            throw new NotImplementedException();
        }

        public static int comprobarValorEnArray(int[] array, int valor)
        {

            for (int i = 0; i < array.Length; i++) {
                if (array[i] == valor) {
                    return i;
                }
            }

            return 0;

            //TODO
            throw new NotImplementedException();
        }

        public static int calcularModa(int[] entrada)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
