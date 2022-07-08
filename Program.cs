using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 17
Запишите подряд в массив A(N) элементы заданного массива B(2N), стоящие на
четных местах, а элементы, стоящие на нечетных местах, запишите в массив C(N). */

namespace _3_1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] C = new int[5];

            int j = 0;
            for (int i = 0; i < B.Length; i += 2)
            {                
                A[j] = B[i];
                j++;                
            }

            j = 0;
            for (int i = 1; i < B.Length; i += 2)
            {
                C[j] = B[i];
                j++;
            }


            for (j = 0; j < A.Length; j++)
                Console.Write(A[j]);

            Console.WriteLine();

            for (j = 0; j < C.Length; j++)
                Console.Write(C[j]);

            Console.ReadKey();
        }
    }
}
