using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_01
{
    class Test_12<T> where T : Animal, IPrintable, new()
    {
        public T Create()
        {
            return new T();
        }
    }

   
}
