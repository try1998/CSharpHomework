using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_6
{
    class Program
    {
        //判断一个数是否为素数
        public static bool isNum(int i)
        {
            if (i == 1)
                return false;
            else if (i == 2)
                return true;
            else
                for (int k=2;k<i;k++)
                {
                    if (i % k == 0)
                    {
                        return false;
                        break;
                    }
                }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数:");
            string s = Console.ReadLine();
            int num = int.Parse(s);

            Console.WriteLine("该整数的素数因数有:");
            for (int i=1;i<=num;i++)
            {
                if (num % i == 0)
                {
                    if (isNum(i))
                        Console.Write(i+" ");
                }
            }
            Console.Read();
        }
    }
}
