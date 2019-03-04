using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //求2~100以内的素数
            int n = 0;
            //定义数组，true代表为素数，false代表不是素数
            bool[] numbers = new bool[100];
            //初始化设置所有数均为true
            for (int k = 0; k < 100; k++)
                numbers[k] = true;

            //从小到大逐步筛选，将相应的倍数设置为false
            for (int a = 2;a <= 50; a++)
            {
                if (numbers[a - 1])
                {
                    for(int b = 2 * a; b <= 100; b += a)
                    {
                        numbers[b - 1] = false;
                    }
                }
            }
            numbers[0] = false;
            Console.WriteLine("2到100之间的素数有:");
            //打印所有素数，满5个换行
            for (int k = 0; k < 100; k++)
            {
                if (numbers[k])
                {
                    n++;
                    if (n <= 5)
                    {
                        Console.Write(k + 1);
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.WriteLine();
                        n = 0;
                    }
                }
                   
            }
            Console.Read();
        }
    }
}
