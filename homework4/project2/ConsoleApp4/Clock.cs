using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Clock
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        private List<Alarm> AlarmlList = new List<Alarm>();
        private int hours;
        private int minutes;
        private int seconds;

        public Clock(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            OnTick += timePass;
            OnAlarm += toAlarm;
        }

        public void start()
        {
            while (true)
            {
                OnTick();
                System.Threading.Thread.Sleep(1000);
                this.seconds++;
                for (int i = 0; i < AlarmlList.Count; i++)
                {
                    if (AlarmlList[i].ToAlarm(this.hours, this.minutes, this.seconds))
                    {
                        OnAlarm();
                    }
                }
            }
        }

        public void setAlarm(int h, int m, int s)
        {
            Alarm a = new Alarm(h, m, s);
            AlarmlList.Add(a);
        }

        public void toAlarm()
        {
            Console.WriteLine("Alarm!!!!!!!");
        }

        public void timePass()
        {
            Console.WriteLine(this.hours + ":" + this.minutes + ":" + this.seconds);
            if (this.seconds == 59)
            {
                this.seconds = -1;
                this.minutes++;
            }
            if (this.minutes == 59)
            {
                this.minutes = -1;
                this.hours++;
            }
            if (this.hours == 23)
                this.hours = -1;
        }

    }
}
