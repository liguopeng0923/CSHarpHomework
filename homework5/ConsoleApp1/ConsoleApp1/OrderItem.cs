using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderItem
    {
        private int OrderId;
        List<Commodity> commoditiesList = new List<Commodity>();
        private Guests guests;
        private  double totalPrice;
        public int OrderId1 { get => OrderId; set => OrderId = value; }
        public Guests Guests { get => guests; set => guests = value; }
        public List<Commodity> CommoditiesList { get => commoditiesList; set => commoditiesList = value; }
        public double TotalPrice { get
            {
                double sum = 0;
                foreach (Commodity commodity in CommoditiesList)
                {
                    sum += commodity.CommodityValue;
                }
                return sum;
            } set => totalPrice = value; }

        public OrderItem(int orderId,Commodity commodity,Guests guests)
        {
            this.OrderId1 = orderId;
            this.CommoditiesList.Add(commodity);
            this.Guests = guests;
        }
        public void purchaseItem(Commodity commodity)
        {
            this.CommoditiesList.Add(commodity);
        }

       
        public void toString()
        {
            Console.WriteLine("OrderId:" + OrderId1);
            Console.WriteLine("Guests:" + Guests.GuestName);
            Console.WriteLine("totalPrice:" + TotalPrice);
            for(int i = 0; i < CommoditiesList.Count; i++)
            {
                Console.WriteLine("CommodityName:"+CommoditiesList[i].CommodityName);
            }
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   OrderId == item.OrderId &&
                   EqualityComparer<List<Commodity>>.Default.Equals(commoditiesList, item.commoditiesList) &&
                   EqualityComparer<Guests>.Default.Equals(guests, item.guests) &&
                   totalPrice == item.totalPrice &&
                   OrderId1 == item.OrderId1 &&
                   EqualityComparer<Guests>.Default.Equals(Guests, item.Guests) &&
                   EqualityComparer<List<Commodity>>.Default.Equals(CommoditiesList, item.CommoditiesList) &&
                   TotalPrice == item.TotalPrice;
        }

        public override int GetHashCode()
        {
            var hashCode = -1939295535;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Commodity>>.Default.GetHashCode(commoditiesList);
            hashCode = hashCode * -1521134295 + EqualityComparer<Guests>.Default.GetHashCode(guests);
            hashCode = hashCode * -1521134295 + totalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderId1.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Guests>.Default.GetHashCode(Guests);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Commodity>>.Default.GetHashCode(CommoditiesList);
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            return hashCode;
        }
    }
}
