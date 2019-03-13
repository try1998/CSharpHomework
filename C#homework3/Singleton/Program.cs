using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class TaskManager
    {
        private static TaskManager tm = null;
        private TaskManager() {} //初始化窗口
        public void displayProcesses() { Console.WriteLine("显示进程"); } //显示进程
        public void displayServices() { Console.WriteLine("显示服务"); } //显示服务
        public static TaskManager getInstance()
        {
            if (tm == null)
            {
                tm = new TaskManager();
            }
            return tm;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TaskManager instance = TaskManager.getInstance();
            instance.displayProcesses();
            instance.displayServices();
            Console.ReadLine();
        }
    }
}
