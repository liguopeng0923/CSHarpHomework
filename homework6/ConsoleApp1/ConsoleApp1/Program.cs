using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1//未进行用户空值输入处理
{
    class Program
    {
        static void Main(string[] args)
        {
                OrderService orderService = new OrderService();
                List<OrderItem> orderItemsList = new List<OrderItem>();
                orderItemsList.Add(new OrderItem(0, new Commodity(0, "0", 0), new Guests(0, "0")));
                Order Order1 = new Order(1, orderItemsList);
                orderService.Order1 = Order1;
                do
                {
                try
                {
                    Console.WriteLine("请输入：0-退出应用，1-添加订单，2-删除订单，3-修改订单，4-查询订单,5-导出xml文件，6-读取xml文件");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            {
                                Console.WriteLine("请输入用户ID，回车后输入姓名");
                                Guests guest1 = new Guests(int.Parse(Console.ReadLine()), Console.ReadLine());
                                do
                                {
                                    Console.WriteLine("分三行依次输入需要购买的商品ID，名称，价格");
                                    Commodity commodity1 = new Commodity(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));
                                    Console.WriteLine("输入订单号");
                                    OrderItem orderItem = new OrderItem(int.Parse(Console.ReadLine()), commodity1, guest1);
                                    Console.WriteLine("仍需购买请输入1，否则输入任意键");
                                    while (Console.ReadLine() == "1")
                                    {
                                        Console.WriteLine("分三行依次输入需要购买的商品ID，名称，价格");
                                        Commodity commodity = new Commodity(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));
                                        orderItem.purchaseItem(commodity);
                                        Console.WriteLine("仍需购买请输入1，否则输入任意键");
                                    }
                                    orderItem.toString();
                                    orderService.Add(orderItem);
                                    Console.WriteLine("仍需添加订单请输入1，否则输入任意键");
                                } while (Console.ReadLine() == "1");
                                Order1.toString();
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("需删除请输入1，否则输入任意键");
                                while (Console.ReadLine() == "1")
                                {
                                    Console.WriteLine("输入需要删除的订单号");
                                    if (Order1.OrderList.Count() != 0)
                                    {
                                        for (int i = 0; i < Order1.OrderList.Count(); i++)
                                        {
                                            if (Order1.OrderList[i].OrderId1 == int.Parse(Console.ReadLine()))
                                            {
                                                orderService.Delete(Order1.OrderList[i]);
                                                Console.WriteLine("删除成功！请回车");
                                            }
                                            else
                                            {
                                                Console.WriteLine("无此订单！请回车");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("订单库存为空！请回车");
                                    }
                                }
                                Order1.toString();
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("需更改请输入1，否则输入任意键");
                                while (Console.ReadLine() == "1")
                                {
                                    Console.WriteLine("输入需要更改的订单号");
                                    int OrderID = int.Parse(Console.ReadLine());
                                    if (Order1.OrderList.Count() != 0)
                                    {
                                        for (int i = 0; i < Order1.OrderList.Count(); i++)
                                        {
                                            if (Order1.OrderList[i].OrderId1 == OrderID)
                                            {
                                                Console.WriteLine("请依次输入新订单的客户ID，客户姓名，第一个商品ID，名称，价格");
                                                Guests guest1 = new Guests(int.Parse(Console.ReadLine()), Console.ReadLine());
                                                Commodity commodity1 = new Commodity(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));
                                                OrderItem orderItem = new OrderItem(OrderID, commodity1, guest1);
                                                Console.WriteLine("仍需加入商品请输入1，否则输入任意键");
                                                while (Console.ReadLine() == "1")
                                                {
                                                    Console.WriteLine("请依次输入商品ID，名称，价格");
                                                    Commodity commodity2 = new Commodity(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));
                                                    orderItem.purchaseItem(commodity2);
                                                    Console.WriteLine("仍需加入商品请输入1，否则输入任意键");
                                                }
                                                orderItem.toString();
                                                orderService.Alter(orderItem);
                                                Console.WriteLine("更改成功！请回车");
                                            }
                                            else
                                            {
                                                Console.WriteLine("无此订单！请回车");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("订单库存为空！请回车");
                                    }
                                }
                                Order1.toString();
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("请选择：1-订单号查询订单，2-商品名称查询订单，3-客户名称查询订单，4-按照订单总额排序订单");
                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("请输入订单号");
                                            orderService.SelectByOrderId(int.Parse(Console.ReadLine())); break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("请输入商品名称");
                                            orderService.SelectByCommodityName(Console.ReadLine()); break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("请输入客户名");
                                            orderService.SelectByGuestName(Console.ReadLine()); break;
                                        }
                                    case 4:
                                        {
                                            orderService.Sort(); break;
                                        }

                                }
                                break;
                            }
                        case "5":
                            {
                                orderService.Export();
                                break;
                            }
                        case "6":
                            {
                                orderService.import();
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("商品名称，用户名称为中文或者英文字符串，价格为小数或者整数，其余为整数。");
                }
                Console.WriteLine("请输入：0-退出应用，其他任意键-新的操作");
                } while (Console.ReadLine() != "0");
        }
    }
}
