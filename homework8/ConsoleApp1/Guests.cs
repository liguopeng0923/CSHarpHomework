﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Guests
    {
        private int guestId;
        private String guestName;

        public int GuestId { get => guestId; set => guestId = value; }
        public string GuestName { get => guestName; set => guestName = value; }
      

        public Guests(int guestId, String guestName)
        {
            this.GuestId = guestId;
            this.GuestName = guestName;
        }
        public Guests()
        {
           
        }

        public void toString()
        {
            Console.WriteLine("GuestId:" + GuestId);
            Console.WriteLine("GuestName:" + GuestName);
        }
        
    }
}
