using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderService
    {
        private Order order1;

        public Order Order1 { get => order1; set => order1 = value; }

        public void Add(OrderItem orderItem)
        {
            try
            {
                Order1.OrderList.Add(orderItem);
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void Delete(OrderItem orderItem)
        {
            try
            {
              Order1.OrderList.Remove(orderItem);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void Alter(OrderItem orderItem)
        {
            try {
                for (int i = 0; i < Order1.OrderList.Count; i++)
                {
                    if (Order1.OrderList[i].OrderId1==orderItem.OrderId1)
                    {
                        Order1.OrderList[i] = orderItem;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
        public IEnumerable<OrderItem> SelectByOrderId(int OrderId)
        {
            var orderItem = from s in Order1.OrderList where s.OrderId1 == OrderId orderby s.TotalPrice select s;
            foreach(OrderItem a in orderItem)
            {
                Console.WriteLine("下一条同类型数据");
                a.toString();
            }
            return orderItem;
        }
        public IEnumerable<OrderItem> SelectByCommodityName(String commodityName)
        {
            var orderItem = Order1.OrderList.Where(s =>
            {
                for (int i = 0; i < s.CommoditiesList.Count(); i++)
                {
                    if (s.CommoditiesList[i].CommodityName == commodityName)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            });
            foreach (OrderItem a in orderItem)
            {
                Console.WriteLine("下一条同类型数据");
                a.toString();
            }
            return orderItem;
        }
        public IEnumerable<OrderItem> SelectByGuestName(String guestName)
        {
            var orderItem = from s in Order1.OrderList where s.Guests.GuestName==guestName orderby s.TotalPrice select s;
            foreach (OrderItem a in orderItem)
            {
                Console.WriteLine("下一条同类型数据");
                a.toString();
            }
            return orderItem;
        }
        public IEnumerable<OrderItem> Sort()
        {
            var orderItem = from s in Order1.OrderList orderby s.TotalPrice select s;
            foreach (OrderItem a in orderItem)
            {
                Console.WriteLine("下一条同类型数据");
                a.toString();
            }
            return orderItem;
        }
    }
}
