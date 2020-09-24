using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ShapeArray();
            printarray(arr);
        }

        public static void ShapeArray()
        {
            int[] arr = new int[10];
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i;
               
            }
            printarray(arr);
            Console.ReadLine();
        }

        public static void printarray(int[] arr)
        {
          ;
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = i;
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
        
    }
}
