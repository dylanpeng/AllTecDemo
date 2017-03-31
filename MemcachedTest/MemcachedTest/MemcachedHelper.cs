using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enyim.Caching;

namespace MemcachedTest
{
    public class MemcachedHelper
    {
        MemcachedClient memClient = new MemcachedClient();

        /// <summary>
        /// 设置缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Set(string key, object value)
        {
            object memValue;
            if (memClient.TryGet(key, out memValue))
            {
                memClient.Remove(key);
            }
            return memClient.Store(Enyim.Caching.Memcached.StoreMode.Add, key, value);
        }

        /// <summary>
        /// 获取缓存 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T Get<T>(string key) where T : class
        {
            object result;
            if (memClient.TryGet(key, out result))
                return result as T;
            return null;
        }

        /// <summary>
        /// 获取缓存 通用方法
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object Get(string key)
        {
            object result;
            if (memClient.TryGet(key, out result))
                return result;
            return null;
        }
    }
}
