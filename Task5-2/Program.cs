using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    class Program
    {
        // Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                if (a < min)
                    min = a;
            }
            Console.WriteLine("Максимальный элемент массива равен {0}", max);
            Console.WriteLine("Минимальный элемент массива равен {0}", min);
            int summaMaxMin = max + min;
            Console.WriteLine("Сумму максимального и минимального элементов массива равна {0}", summaMaxMin);
            Console.ReadKey();
        }
    }
}
