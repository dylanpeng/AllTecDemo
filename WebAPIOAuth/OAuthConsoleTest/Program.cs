using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OAuthConsoleTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var clientTest = new OAuthClientTest();
            var task = clientTest.Call_WebAPI_By_Resource_Owner_Password_Credentials_Grant();
            task.Wait();
            //var token = clientTest.GetAccessToken();
            //var strToken = token.Result;
            //Console.WriteLine(strToken);
            Console.ReadLine();
        }

    }
}
