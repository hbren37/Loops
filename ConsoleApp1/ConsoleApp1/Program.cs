using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please enter a starting point");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an end");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("N\t10*N\t100*N\t1000*N");
            Console.WriteLine("-\t-------\t--------");

            Console.WriteLine("<<<For loop>>>");
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i}  {i * 10}  {i * 100}  {i * 1000}");
            }

            Console.WriteLine("<<<While Loop>>>");
            int j = start;
            while (j <= end)
            {
                Console.WriteLine($"{j}  {j * 10}  {j * 100}  {j * 1000}");
                j++;

            }

            Console.WriteLine("<<<While Loop>>>");
            int k = start;
            do
            {
                Console.WriteLine($"{k}  {k * 10}  {k * 100}  {k * 1000}");
                k++;

            }
            while (k <= end);


            {
                Console.WriteLine("Please enter a times table you'd like to know");
                int num = int.Parse(Console.ReadLine());


                Console.WriteLine($"{num} x tables");
                Console.WriteLine("<<<For Loop>>>");
                for (int z = 0; z <= 12; z++)
                    Console.WriteLine($"{num} x {z} = { num * z}");

            }


















            }
        }
}
