using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace ConsoleApp1 {
  public class OrderService {
    private List<OrderItem> orderList = new List<OrderItem>();

    public List<OrderItem> Orders { get => OrderList; }
        public List<OrderItem> OrderList { get => orderList; set => orderList = value; }

        public void Add(OrderItem orderItem) {
      bool judge = true;
      try {
        foreach (OrderItem x in OrderList) {
          if (x.OrderId1 == orderItem.OrderId1) {
            Console.WriteLine("此订单已存在,无法进行对同一订单号的添加");
            judge = false;
          }

        }
        if (judge) {
          OrderList.Add(orderItem);
        }

      }
      catch (Exception e) {
        Console.WriteLine(e);
      }
    }
    public void Delete(OrderItem orderItem) {
      try {
        OrderList.Remove(orderItem);
      }
      catch (Exception e) {
        Console.WriteLine(e);
      }
    }
    public void Alter(OrderItem orderItem) {
      try {
        for (int i = 0; i < OrderList.Count; i++) {
          if (OrderList[i].OrderId1 == orderItem.OrderId1) {
            OrderList[i] = orderItem;
          }
        }
      }
      catch (Exception e) {
        Console.WriteLine(e);
      }

    }
    public IEnumerable<OrderItem> SelectByOrderId(int OrderId) {
      var orderItem = from s in OrderList where s.OrderId1 == OrderId orderby s.TotalPrice select s;
      foreach (OrderItem a in orderItem) {
        Console.WriteLine("下一条同类型数据");
        a.toString();
      }
      return orderItem;
    }
    public IEnumerable<OrderItem> SelectByCommodityName(String commodityName) {
      var orderItem = OrderList.Where(s => {
        for (int i = 0; i < s.CommoditiesList.Count(); i++) {
          if (s.CommoditiesList[i].CommodityName == commodityName) {
            return true;
          }
        }
        return false;
      });
      var ordeItem2 = orderItem.OrderBy(s => {
        return s.TotalPrice;
      });
      foreach (OrderItem a in ordeItem2) {
        Console.WriteLine("下一条同类型数据");
        a.toString();
      }
      return orderItem;
    }
    public IEnumerable<OrderItem> SelectByGuestName(String guestName) {
      var orderItem = from s in OrderList where s.Guests.GuestName == guestName orderby s.TotalPrice select s;
      foreach (OrderItem a in orderItem) {
        Console.WriteLine("下一条同类型数据");
        a.toString();
      }
      return orderItem;
    }
    public IEnumerable<OrderItem> Sort() {
      var orderItem = from s in OrderList orderby s.TotalPrice select s;
      foreach (OrderItem a in orderItem) {
        Console.WriteLine("下一条同类型数据");
        a.toString();
      }
      return orderItem;
    }
    public XmlSerializer xmlList = new XmlSerializer(typeof(List<OrderItem>));
    public void Export() {

      using (FileStream fs = new FileStream("order.xml", FileMode.Create)) {
        xmlList.Serialize(fs, OrderList);
      }
      Console.WriteLine("\nSerialized as Xml:");
      Console.WriteLine(File.ReadAllText("order.xml"));
    }
    public List<OrderItem> import() {
      using (FileStream fs = new FileStream("order.xml", FileMode.Open)) {
        List<OrderItem> orderItemsList = (List<OrderItem>)xmlList.Deserialize(fs);
                return orderItemsList;
      }
    }
  }
}
