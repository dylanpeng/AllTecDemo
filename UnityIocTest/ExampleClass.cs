using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIocTest
{
    public class ExampleClass : IExampleClass
    {
        public void DoHelloWord()
        {
            Console.WriteLine("Hello Word!");
        }
    }
}
