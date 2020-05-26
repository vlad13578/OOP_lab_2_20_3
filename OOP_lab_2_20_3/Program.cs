using System;

namespace OOP_lab_2_20_3
{
    class Program
    {
        public static int maxARR(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (max <= arr[i])
                    max = arr[i];
            }
            return max;
        }

        public static int dob(int[] arr)
        {
            int d = 1;
            int start = 0;
            int end = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    start = i;
                    break;
                }
            }
            for (int i = arr.Length - 1; i > 0; --i)
            {
                if (arr[i] < 0)
                {
                    end = i;
                    break;
                }
            }
            for (int i = start + 1; i < end; ++i)
            {
                d *= arr[i];
            }
            if (end <= start)
                return 0;
            else
                return d;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            var r = new Random();
            for (int i = 0; i < n; ++i)
            {
                a[i] = r.Next(-100, 100);
            }
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Максимальний елемент масиву: {0}", maxARR(a));
            Console.WriteLine("Добуток елементiв масиву, розсташованих мiж першим й останнiм вiд'ємними елементами: {0}", dob(a));
        }
    }

}
