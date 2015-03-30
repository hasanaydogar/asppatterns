using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Chap2.Service
{
    public class NullObjectCache : ICacheStorage
    {
        public void Remove(string key)
        {
            // Do Nothing
        }

        public void Store(string key, object data)
        {
          // Do Nothing
        }

        public T Retrieve<T>(string key)
        {
            return default(T);
        }
    }
}
