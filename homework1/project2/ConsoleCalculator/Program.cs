using System;

namespace ConsoleCalculator
{
    using System;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("这是一个小型计算器");
            Console.WriteLine("请输入第一个操作数");
            string a = Console.ReadLine();
            Console.WriteLine("请输入第二个操作数");
            string b = Console.ReadLine();
            double ad, bd;
            if (double.TryParse(a, out ad) && double.TryParse(b, out bd))
            {
                double c = 0;
                Console.WriteLine("请输入操作符+，-，*，/");
                string d = Console.ReadLine();
                if (d == "+")
                    c = ad + bd;
                else if (d == "-")
                    c = ad - bd;
                else if (d == "*")
                    c = ad * bd;
                else if (d == "/")
                    if (bd == 0)
                        Console.WriteLine("错误！除数不可为0！");
                    else
                        c = ad / bd;
                else
                    Console.WriteLine("运算符异常");

                Console.WriteLine("运算结果为"+c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("输入字符无法计算！请重启计算器");
                while (true) ;
            }
        }
    }
   
}
