using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數:");
            int.TryParse(Console.ReadLine(),out int num);
            int i = 2;

            if (num >= 2)
            {
                while (i < num)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("不是質數");
                        break;
                    }
                    i++;
                }
                if (i == num)
                {
                    Console.WriteLine("是質數");
                }
            }
            else
            {
                Console.WriteLine("請輸入大於2的正整數!");
            }
        }
    }
}


