using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Alarm
{
    //声明事件参数类型
    public class AlarmEventArgs : EventArgs
    {
        public int orderTime;
        
    }

    //声明委托类型
    public delegate void AlarmEventHandler(object self, AlarmEventArgs e);

    //定义事件源
    public class Alarm
    {
        public event AlarmEventHandler MyAlarm;
     
        public void DoAlarm(int orderTime)
        {
            AlarmEventArgs args = new AlarmEventArgs();
            args.orderTime = orderTime;
            MyAlarm(this, args);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            //注册事件
            alarm.MyAlarm += Alarm_MyAlarm;
            Console.WriteLine("输入定时时间(以秒计)");
            int time = int.Parse(Console.ReadLine());
            alarm.DoAlarm(time);
        }

        //定义事件处理方法
        private static void Alarm_MyAlarm(object self, AlarmEventArgs args)
        {
            int alarmTime = args.orderTime;
            Console.WriteLine("定时开始");
            System.Threading.Thread.Sleep(alarmTime*1000);
            Console.WriteLine("叮咛咛咛咛！！！！！");
            Console.ReadLine();
        }

       
      
    }
}