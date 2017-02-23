using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MsmqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var msmqManager = new MSMQManager();
            for (int i = 1; i <= 10; i++)
            {
                msmqManager.Send(string.Format("消息{0}", i));
            }
            var msg = msmqManager.ReceiveMessage();
            msmqManager.WriteAllMessage();
            Console.ReadLine();
        }
    }
}
