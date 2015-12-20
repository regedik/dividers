using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace divider
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Input number: ");

            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                num = 0;
            }

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            
            Console.ReadKey(true);
        }
    }
}
