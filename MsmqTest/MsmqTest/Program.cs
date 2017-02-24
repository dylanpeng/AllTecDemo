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
                MsmqData data = new MsmqData() { Id = i, Name = string.Format("Name{0}", i) };
                //发送消息
                msmqManager.Send(data);
            }
            var msg = msmqManager.ReceiveMessage();
            msmqManager.WriteAllMessage();
            Console.ReadLine();
        }
    }
}
