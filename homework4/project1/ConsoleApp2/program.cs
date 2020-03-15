using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                int a = 0;
                if(int.TryParse(Console.ReadLine(), out a)) {
                    list.Add(a);
                }
                else
                {
                    Console.WriteLine("请输入整数！");
                }
                
            }
            list.ForEach(x => Console.WriteLine(x));
            int sum = 0;
            list.ForEach(x=> { sum += x; });
            int max = list.Head.Data;
            list.ForEach(x=> { max = x > max ? x : max; });
            int min = list.Head.Data;
            list.ForEach(x=> { min = x < min ? x : min; });
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);
            while (true) ;
        }
    }
}
