//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADVC_01
//{
//    internal class Cache<TKey, TValue>
//    {
//        private class CacheItem
//        {
//            public TValue Value;
//            public DateTime ExpirationTime;

//            public CacheItem(TValue value, TimeSpan expiration)
//            {
//                Value = value;
//                ExpirationTime = DateTime.Now.Add(expiration);
//            }
//        }

//        private Dictionary<TKey, CacheItem> items = new Dictionary<TKey, CacheItem>();

//        public void Add(TKey key, TValue value, TimeSpan expiration)
//        {
//            CacheItem item = new CacheItem(value, expiration);

//            items[key] = item;
//        }

//        public TValue Get(TKey key)
//        {
//            if (items.ContainsKey(key))
//            {
//                CacheItem item = items[key];

//                if (DateTime.Now < item.ExpirationTime)
//                {
//                    return item.Value;
//                }

//                items.Remove(key);
//            }

//            return default(TValue);
//        }

//        public void Remove(TKey key)
//        {
//            if (items.ContainsKey(key))
//            {
//                items.Remove(key);
//            }
//        }

//        public bool Contains(TKey key)
//        {
//            if (items.ContainsKey(key))
//            {
//                CacheItem item = items[key];

//                if (DateTime.Now < item.ExpirationTime)
//                {
//                    return true;
//                }

//                items.Remove(key);
//            }

//            return false;
//        }
//    }
//}
