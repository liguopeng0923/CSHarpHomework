using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.编写程序输出用户指定数据的所有素数因子。
2.编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
3.用“埃氏筛法”求2 ~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再
 去掉4的倍数，以此类推...最后剩下的就是素数。*/
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数，此程序用作计算您输入的整数的素数因子");
            String number= Console.ReadLine();
            int numberInt;
            if(int.TryParse(number,out numberInt) != true) {
                Console.WriteLine("请重启程序，输入整数");
            }
            if (numberInt < 0)
            {
                Console.WriteLine("请输入正整数");
            }
            int divisor = 2;
            bool once=true;
            while (numberInt != 1)
            {
                if (numberInt % divisor == 0)
                {
                    numberInt /= divisor;
                    if (once) {
                        Console.WriteLine("素因子为" + divisor);
                        once = false;
                    }
                   
                }
                else
                {
                    divisor++;
                    once = true;
                }
            }
            Console.ReadLine();
        }
    }
}
