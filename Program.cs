using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week11_1");
            int sum1 = 0, sum2 = 0, sum3 = 0;
            Console.Write("請輸入x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("請輸入y:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("請輸入上限值n:");
            int n = int.Parse(Console.ReadLine());
            for (x = x; x <= n; x++)
            {
                sum1 += 2 * x * x - 2 * x + 10;
                for (y = y; y <= n; y++)
                {
                    sum2 += 2 * x - 3 * y;
                    sum3 += 2 * x * x - 7 * x * y;
                }
            }
            Console.WriteLine("(1){0},(2){1},(3){2}", sum1, sum2, sum3);
            Console.ReadLine();
        }
    }
}
