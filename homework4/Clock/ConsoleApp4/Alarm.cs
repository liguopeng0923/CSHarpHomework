using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Alarm
    {
        private int hours;
        private int minutes;
        private int seconds;
        public Alarm(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public bool ToAlarm(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
                return true;
            return false;
        }
    }

}
