using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            Console.WriteLine("请输入第一个数字:");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字:");
            num2 = Double.Parse(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine(num1 + "*" + num2 +"="+result);
            Console.ReadLine();
        }
    }
}
