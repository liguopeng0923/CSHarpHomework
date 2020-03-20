using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        private int orderNumber;
        List<OrderItem> orderList = new List<OrderItem>();
        public int OrderNumber { get {
                return OrderList.Count;
            } set => orderNumber = value; }
        public List<OrderItem> OrderList { get => orderList; set => orderList = value; }
        public Order(int orderNumber, List<OrderItem> orderList)
        {
            this.OrderNumber = OrderNumber;
            this.OrderList = OrderList;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   orderNumber == order.orderNumber &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(orderList, order.orderList) &&
                   OrderNumber == order.OrderNumber &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(OrderList, order.OrderList);
        }

        public override int GetHashCode()
        {
            var hashCode = -1400497446;
            hashCode = hashCode * -1521134295 + orderNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(orderList);
            hashCode = hashCode * -1521134295 + OrderNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(OrderList);
            return hashCode;
        }
        public void toString()
        {
            Console.WriteLine("orderNumber:" + OrderNumber);
            foreach(OrderItem orderItem in OrderList)
            {
                Console.WriteLine("OrderId:" + orderItem.OrderId1);
            }
        }
    }
    
}
