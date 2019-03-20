using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Order
    {
        public string id;  //订单号
        public string name; //商品名称
        public string clientName; //客户
        public Order(string id, string name, string clientName)
        {
            this.id = id;
            this.name = name;
            this.clientName = clientName;
        }
        //展示订单信息
        public void show()
        {
            Console.WriteLine("订单编号:" + this.id);
            Console.WriteLine("订单名字:" + this.name);
            Console.WriteLine("客户名称:" + this.clientName);
        }
    }


    class OrderService
    {
        List<Order> Orderlist = new List<Order>(); //存放订单数据
        //添加订单
        public void AddOrder()
        {
            Console.WriteLine("输入添加的订单信息:");
            Console.WriteLine("输入添加的订单编号:");
            string id = Console.ReadLine();
            Console.WriteLine("输入添加的订单名字:");
            string name = Console.ReadLine();
            Console.WriteLine("输入添加的订单客户名称:");
            string clientName = Console.ReadLine();
            Order newOrder = new Order(id, name, clientName);  //生成订单
            Orderlist.Add(newOrder);
        }

        //删除订单
        public void DeleteOrder()
        {
            Console.WriteLine("请问您要删除哪一个订单:");
            Order DeleteOrder = SearchOrder();
            try
            {
                Orderlist.Remove(DeleteOrder);
                Console.WriteLine("删除完毕");
            }
            
            catch (NullReferenceException e)
            {
                Console.WriteLine("查无此订单！" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("删除无效！" + e.Message);
            }
        
        }

        //修改订单
        public void ModifyOrder()
        {
            Console.WriteLine("请问您要修改哪一个订单:");
            Order ModifyOrder = SearchOrder();
            Console.WriteLine("请问要修改那一项数据:");
            Console.WriteLine("1:修改编号/2：修改名字/3：修改客户名称");
            int OrderCode = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入修改的数据");
            string ModifiedData = Console.ReadLine();
            try
            {
                switch (OrderCode)
                {
                    case 1:
                        ModifyOrder.id = ModifiedData;
                        break;
                    case 2:
                        ModifyOrder.name = ModifiedData;
                        break;
                    case 3:
                        ModifyOrder.clientName = ModifiedData;
                        break;
                    default:

                        Console.WriteLine("不存在此服务");
                        break;

                }
                
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("查无此订单！" + e.Message);   
            }
            catch (Exception e)
            {
                Console.WriteLine("修改无效！" + e.Message);
            }
        }
        
        //查询订单
        public Order SearchOrder()
        {
            Order thatOrder=null;
            Console.WriteLine("1:按编号查询/2：按名字查询/3：按客户名称查询");
            int OrderCode = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入查找数据");
            string SearchData = Console.ReadLine();
            try
            {
                switch (OrderCode)
                {
                    case 1:
                        foreach (Order order in Orderlist)
                        {
                            if (order.id == SearchData)
                            {
                                order.show();
                                thatOrder = order;
                                //return order;
                            }
                        }
                        break;
                    case 2:
                        foreach (Order order in Orderlist)
                        {
                            if (order.name == SearchData)
                            {
                                order.show();
                                thatOrder = order;
                                //return order;
                            }
                        }
                        break;
                    case 3:
                        foreach (Order order in Orderlist)
                        {
                            if (order.clientName == SearchData)
                            {
                                order.show();
                                thatOrder = order;
                                //return order;
                            }
                        }
                        break;
                    default:
                        
                        Console.WriteLine("不存在此服务");
                        break;
                        
                }
                return thatOrder;
            }
            
            catch (NullReferenceException e)
            {
                Console.WriteLine("查无此订单！" + e.Message);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("查询无效！" + e.Message);
                return null;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("订单管理系统:");
            OrderService orderService = new OrderService();
            while (true) { 
            Console.WriteLine("1.添加订单/2.删除订单/3.修改订单/4.查询订单");
            int OrderCode = int.Parse(Console.ReadLine());
                switch (OrderCode)
                {
                    case 1:
                        orderService.AddOrder();
                        break;
                    case 2:
                        orderService.DeleteOrder();
                        break;
                    case 3:
                        orderService.ModifyOrder();
                        break;
                    case 4:
                        orderService.SearchOrder();
                        break;
                    default:
                        Console.WriteLine("不存在此服务！");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
