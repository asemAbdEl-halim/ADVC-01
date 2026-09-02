//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADVC_01
//{
//    internal class SafeList<T>
//    {
//        private T[] items;

//        public SafeList(T[] items)
//        {
//            this.items = items;
//        }

//        public T Get(int index)
//        {
//            if (index >= 0 && index < items.Length)
//            {
//                return items[index];
//            }

//            return default(T);
//        }
//    }
//}
