using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleOutput.ConsoleEnabled = true;
            ConsoleRun();
        }

        private static void ConsoleRun()
        {

            Console.Title = "后台程序示例";
            Console.WriteLine("程序开始");
            var backgroudWorker = new BackgroundWorker { WorkerSupportsCancellation = true };
            backgroudWorker.DoWork += DoJob;
            backgroudWorker.RunWorkerAsync();
            Console.ReadLine();
            Console.Title = Console.Title + "正在关闭";
            backgroudWorker.CancelAsync();
            Console.WriteLine(@"
 **************************************** 
 *                                      * 
 *  服务已停止。请按回车键关闭此窗口          *
 * （此程序需要每天运行。请不要随意关闭 ^_^）  * 
 *                                      * 
 **************************************** 
");
            Console.Title = Console.Title.Replace("正在关闭", "已停止");
            Console.ReadLine();
        }

        private static void DoJob(object sender, DoWorkEventArgs e)
        {
            var backggroudWorder = (BackgroundWorker)sender;
            ConsoleClass.Execute(backggroudWorder);
        }
    }
}
