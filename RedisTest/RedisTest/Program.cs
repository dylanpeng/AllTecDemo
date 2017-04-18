using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "test", value = "http://www.sina.com";
            bool isRight = RedisHelper.StringSet(key, value);
            if(isRight)
                Console.WriteLine("保存Redis:key.{0} value.{1}成功", key, value);
            string result = RedisHelper.StringGet(key);
            Console.WriteLine("Redis:key.{0} value.{1}", key, result);
            var model = new TestModel() { Id = 100, Name = "RedisValue" };
            isRight = RedisHelper.Set<TestModel>("model", model, new TimeSpan(0, 10, 0));
            var modelResult = RedisHelper.Get<TestModel>("model");
            if(modelResult != null)
                Console.WriteLine("RedisModel:Id.{0} Name.{1}", modelResult.Id, modelResult.Name);
            Console.ReadLine();
        }
    }

    [Serializable]
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
