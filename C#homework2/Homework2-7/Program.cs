using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0, min=0,sum=0;
            double average;
            int index = 0;
            //获取数组大小，定义数组，分配内存
            Console.WriteLine("输入数组大小:");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            //给数组内每一个元素赋值
            while (index<size)
            {
                do { Console.WriteLine("请输入第{0}个整数", index + 1); }
                while (int.TryParse(Console.ReadLine(), out numbers[index]) == false);
                index++;
            }

            for (int k = 0; k < size; k++)
            {
                if (numbers[k] > max)
                    max = numbers[k];
                if (numbers[k] < min)
                    min = numbers[k];
                sum += numbers[k];
            }
            average = sum / size;

            Console.WriteLine($"该数组的最大值是{max}，最小值是{min}，总和是{sum}，平均数是{average}");
            Console.Read();
        }
    }
}
