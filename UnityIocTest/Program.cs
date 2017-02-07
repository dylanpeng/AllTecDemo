using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIocTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dao = UnitySingleton.GetInstanceDAL<IExampleClass>();
            var dao = UnitySingleton.GetInstanceDAL<DIExampleClass>();
            dao.DoWork();
            Console.ReadLine();
        }
    }
}
