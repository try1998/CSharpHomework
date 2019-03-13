using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    //抽象产品类
    public interface Chart
    {
        void display();
    }

    //具体产品类:柱状图
    class HistogramChart : Chart
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图！");
        }

        public void display()
        {
            Console.WriteLine("显示柱状图！");
        }
    }

    //具体产品类:饼状图
    class PieChart : Chart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图！");
        }

        public void display()
        {
            Console.WriteLine("显示饼状图！");
        }
    }

    //具体产品类:折线图
    class LineChart : Chart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图！");
        }

        public void display()
        {
            Console.WriteLine("显示折线图！");
        }
    }

    //图标工厂类
    class ChartFactory
    {
        public static Chart getChart(string type)
        {
            Chart chart = null;
            if (type == "histogram") 
            {
                chart = new HistogramChart();
                Console.WriteLine("初始化设置柱状图！");
            }
            else if (type=="pie")
            {
                chart = new PieChart();
                Console.WriteLine("初始化设置饼状图！");
            }
            else if (type=="line")
            {
                chart = new LineChart();
                Console.WriteLine("初始化设置折线图！");
            }
            return chart;
        }
    }

    //客户端测试
    class Client
    {
        public static void Main(String []args)
        {
            Chart chart;
            chart = ChartFactory.getChart("histogram"); //通过静态工厂方法创建产品
            chart.display();
            chart = ChartFactory.getChart("pie");
            chart.display();
            chart = ChartFactory.getChart("line");
            chart.display();
            
        }
    }
}