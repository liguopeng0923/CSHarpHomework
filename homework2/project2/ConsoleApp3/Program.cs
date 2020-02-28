using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.编写程序输出用户指定数据的所有素数因子。
2.编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
3.用“埃氏筛法”求2 ~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再
 去掉4的倍数，以此类推...最后剩下的就是素数。*/
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字个数");
            String numberString = Console.ReadLine();
            if (int.TryParse(numberString,out int numberInt)!=true)
            {
                Console.WriteLine("请输入整数");
            }
            int[] arrayInt = new int[numberInt];
            for(int i = 0; i < numberInt; i++)
            {
                Console.WriteLine("请输入第"+(i+1)+"个数");
                String numberString1 = Console.ReadLine();
                if (int.TryParse(numberString1, out int numberInt1) != true)
                {
                    Console.WriteLine("请输入整数");
                }
                arrayInt[i] = numberInt1;
            }
            Console.WriteLine("最大值" + maxNumber(arrayInt));
            Console.WriteLine("最小值" + minNumber(arrayInt));
            Console.WriteLine("元素之和" + sumNumber(arrayInt));
            double averageNumber = sumNumber(arrayInt) / numberInt;
            Console.WriteLine("平均值" + averageNumber);
            Console.ReadLine();
        }
        static int maxNumber(int[] array)
        {
            int max = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int minNumber(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static int sumNumber(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
