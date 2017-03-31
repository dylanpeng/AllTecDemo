using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enyim.Caching;

namespace MemcachedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MemcachedHelper memHelper = new MemcachedHelper();
                //缓存字符串
                memHelper.Set("memStr", "Hello World!");
                var a = memHelper.Get("memStr");
                Console.WriteLine(a);
                //缓存类型
                memHelper.Set("memClass", new MemClass() { Id = 1, Name = "class" });
                var b = memHelper.Get<MemClass>("memClass");
                Console.WriteLine(string.Format("Id:{0} Name:{1}", b.Id, b.Name));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }


    [Serializable]//注：缓存类型一定要加可序列化的特性，否则无法缓存成功
    public class MemClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
