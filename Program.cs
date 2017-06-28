using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 5, 1, 3, 8, 4, 7, 9, 6, 2 };

            printArray(myArray);

            myInsertSort(myArray);

            printArray(myArray);

            Console.WriteLine();
        }

        static void printArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        static void myInsertSort(int [] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int x = i + 1;
                int tmp = array[x];

                while(x > 0 && array[x - 1] > tmp)
                {
                    array[x] = array[x - 1];
                    x--;
                }

                array[x] = tmp;
            }
        }
    }
}
