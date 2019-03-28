using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {

    class MainClass {
        public static void Main() {
            try {
                Customer customer1 = new Customer(1, "Customer1");
                Customer customer2 = new Customer(2, "Customer2");
                Customer customer3 = new Customer(3, "Customer3");   //3号顾客点的订单用来测试新加的功能

                Goods milk = new Goods(1, "Milk", 69.9);
                Goods eggs = new Goods(2, "eggs", 4.99);
                Goods apple = new Goods(3, "apple", 5.59);

                OrderDetail orderDetails1 = new OrderDetail(1, apple, 8);
                OrderDetail orderDetails2 = new OrderDetail(2, eggs, 2);
                OrderDetail orderDetails3 = new OrderDetail(3, milk, 1);

                Order order1 = new Order(1, customer1);
                Order order2 = new Order(2, customer2);
                Order order3 = new Order(3, customer2);
             
                // Order order4 = new Order(4, customer3);
                Object order5 = new Order(5, customer3);   //5号订单用来测试接口实现的Compareto方法

                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);
                order1.AddDetails(orderDetails3);
                //order1.AddOrderDetails(orderDetails3);
                order2.AddDetails(orderDetails2);
                order2.AddDetails(orderDetails3);
                order3.AddDetails(orderDetails3);
                //order4.AddDetails(orderDetails2);   
                //order4.AddDetails(orderDetails2);    //4号订单与2号订单重复

                OrderService os = new OrderService();
                os.AddOrder(order1);
                os.AddOrder(order2);
                os.AddOrder(order3);
                
                //os.AddOrder(order4);     //会报错，因为和2号订单重复

                Console.WriteLine("GetAllOrders");
                List<Order> orders = os.QueryAllOrders();
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("GetOrdersByCustomerName:'Customer2'");
                orders = os.QueryByCustomerName("Customer2");
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());

                Console.WriteLine("GetOrdersByGoodsName:'apple'");
                orders = os.QueryByGoodsName("apple");
                foreach (Order order in orders)
                    Console.WriteLine(order);

                Console.WriteLine("Remove order(id=2) and qurey all");
                os.RemoveOrder(2);
                os.QueryAllOrders().ForEach(
                    od => Console.WriteLine(od));

                Console.WriteLine("测试2号订单和5号订单的排序（实现接口方法）：");
                Console.WriteLine(order2.CompareTo(order5));

                os.RemoveOrder(5);
                os.AddOrder(order2);
                os.SortById();    //id排序
                Console.WriteLine("按照订单总金额排序:");
                os.SortByMoney(); //金额排序
                foreach (Order order in orders)
                    Console.WriteLine(order.ToString());


            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
