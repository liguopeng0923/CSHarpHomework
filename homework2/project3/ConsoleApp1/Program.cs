using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 1.编写程序输出用户指定数据的所有素数因子。
2.编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
3.用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再
去掉4的倍数，以此类推...最后剩下的就是素数。*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[99];
            for(int i = 2; i <= 100; i++)
            {
                array[i - 2] = i;
            }
            for(int i = 2; i <= 100; i++)
            {
                for(int j = 2; j <= 10; j++)
                {
                    if (array[i - 2] % j == 0&&array[i-2]!=j)
                    {
                        array[i - 2] = 0;
                    }
                }
            }
            for(int i = 0; i < 99; i++)
            {
                if (array[i] != 0)
                {
                    Console.WriteLine("素数有" + array[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
