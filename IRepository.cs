using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_01
{
    interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        void Delete(int id);
    }
}
