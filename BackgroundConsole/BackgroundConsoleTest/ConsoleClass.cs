using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundConsoleTest
{
    public class ConsoleClass
    {
        public static void Execute(BackgroundWorker backgroundWorkker)
        {
            try
            {
                while (!backgroundWorkker.CancellationPending)
                {
                    ConsoleOutput.ShowInfomationLine("do job here!");
                    Thread.Sleep(1000 * 10);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
