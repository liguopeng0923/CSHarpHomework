using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();
        List<OrderItem> orderItemsList = new List<OrderItem>();
        OrderItem orderItem = new OrderItem(0, new Commodity(0, "0", 0), new Guests(0, "0"));
        OrderItem orderItemAlter = new OrderItem(0, new Commodity(1, "1", 1), new Guests(1, "1"));
        OrderItem orderItem1 = new OrderItem(1, new Commodity(1, "1", 1), new Guests(1, "1"));
        OrderItem orderItem2 = new OrderItem(2, new Commodity(2, "2", 2), new Guests(2, "2"));
        [TestMethod()]
        public void AddTest()
        {

            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderItemsList.Add(orderItem);
            orderService.Add(orderItem);
            Assert.AreEqual(orderItemsList[0],orderService.Order1.OrderList[0]);
        }
        [TestMethod()]
        public void DeleteTest()
        {
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderItemsList.Add(orderItem);
            orderService.Add(orderItem);
            orderItemsList.Add(orderItem1);
            orderService.Add(orderItem1);
            orderItemsList.Remove(orderItem);
            orderService.Delete(orderItem);
            Assert.AreEqual(orderItemsList[0], orderService.Order1.OrderList[0]);
        }

        [TestMethod()]
        public void AlterTest()
        {
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderItemsList.Add(orderItemAlter);
            orderService.Add(orderItem);
            orderService.Alter(orderItemAlter);
            Assert.AreEqual(orderItemsList[0], orderService.Order1.OrderList[0]);
        }

        [TestMethod()]
        public void SelectByOrderIdTest()
        {
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderItemsList.Add(orderItem);
            orderService.Add(orderItem1);
            orderService.Add(orderItem2);
            orderService.Add(orderItem);
            Assert.AreEqual(orderItemsList[0], orderService.SelectByOrderId(0).ToList()[0]);
        }

        [TestMethod()]
        public void SelectByCommodityNameTest()
        {
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderItemsList.Add(orderItem);
            orderService.Add(orderItem1);
            orderService.Add(orderItem2);
            orderService.Add(orderItem);
            Assert.AreEqual(orderItemsList[0], orderService.SelectByCommodityName("0").ToList()[0]);
        }

        [TestMethod()]
        public void SelectByGuestNameTest()
        {
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderItemsList.Add(orderItem);
            orderService.Add(orderItem1);
            orderService.Add(orderItem2);
            orderService.Add(orderItem);
            Assert.AreEqual(orderItemsList[0], orderService.SelectByGuestName("0").ToList()[0]);
        }

        [TestMethod()]
        public void SortTest()
        {
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderItemsList.Add(orderItem);
            orderItemsList.Add(orderItem1);
            orderItemsList.Add(orderItem2);
            orderService.Add(orderItem1);
            orderService.Add(orderItem2);
            orderService.Add(orderItem);
            for(int i = 0; i < orderItemsList.Count; i++)
            {
                Assert.AreEqual(orderItemsList[i], orderService.Sort().ToList()[i]);
            }
        }
        public XmlSerializer xmlList = new XmlSerializer(typeof(List<OrderItem>));
        [TestMethod()]
        public void ExportTest()
        {
            using (FileStream fs = new FileStream("test.xml", FileMode.Create))
            {
                orderItemsList.Add(orderItem);
                orderItemsList.Add(orderItem1);
                orderItemsList.Add(orderItem2);
                xmlList.Serialize(fs, orderItemsList);
            }
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderService.Add(orderItem);
            orderService.Add(orderItem1);
            orderService.Add(orderItem2);
            orderService.Export();
            Assert.AreEqual(File.ReadAllText("test.xml"),File.ReadAllText("order.xml"));
        }

        [TestMethod()]
        public void importTest()
        {
            using (FileStream fs = new FileStream("test.xml", FileMode.Create))
            {
                orderItemsList.Add(orderItem);
                orderItemsList.Add(orderItem1);
                orderItemsList.Add(orderItem2);
                xmlList.Serialize(fs, orderItemsList);
            }
            Order Order1 = new Order(1, orderItemsList);
            orderService.Order1 = Order1;
            orderService.Add(orderItem);
            orderService.Add(orderItem1);
            orderService.Add(orderItem2);
            orderService.Export();
            List<OrderItem> order=new List<OrderItem>();
            List<OrderItem> test = new List<OrderItem>(); 
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                List<OrderItem> orderItemsList = (List<OrderItem>)xmlList.Deserialize(fs);
                order = orderItemsList;
            }
            using (FileStream fs = new FileStream("test.xml", FileMode.Open))
            {
                List<OrderItem> orderItemsList = (List<OrderItem>)xmlList.Deserialize(fs);
                test = orderItemsList;
            }
            for(int k = 0; k < 3; k++)
            {
                Assert.AreEqual(order[k].OrderId1, test[k].OrderId1);
            }
        }
    }
}