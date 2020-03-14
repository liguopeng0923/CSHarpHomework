using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    public delegate void TickHandler();
    public delegate void AlarmHandler();
 
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock(0, 0, 0);
            myClock.setAlarm(0, 0, 10);
            myClock.setAlarm(0, 0, 20);
            myClock.start();
        }
    }
}
