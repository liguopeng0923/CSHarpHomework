﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Commodity
    {
        private int commodityId;
        private String commodityName;
        private double commodityValue;
        public int CommodityId { get => commodityId; set => commodityId = value; }
        public string CommodityName { get => commodityName; set => commodityName = value; }
        public double CommodityValue { get => commodityValue; set => commodityValue = value; }

        public Commodity(int commodityId,String commdityName,double commodityValue)
        {
                this.CommodityId = commodityId;
                this.CommodityName = commdityName;
                this.CommodityValue = commodityValue;
            
        }
        public Commodity()
        {
        }

        public void toString()
        {
            Console.WriteLine("CommodityId:" + CommodityId);
            Console.WriteLine("CommodityName:" + CommodityName);
            Console.WriteLine("CommodityValue:" + CommodityValue);
        }
    }
}
