using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WcfService.WcfServiceClient();
            try
            {
                var str = client.GetData(2046);
                Console.WriteLine(string.Format("内容:{0}", str));
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("出现异常！");
                client.Abort();
            }
            Console.ReadLine();
        }
    }
}
