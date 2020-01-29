using System;
using System.Collections.Generic;

namespace Delegate
{
    class CustList<T> : List<T>
    {
        public List<T> FindList(Func<T, bool> criteria)
        {
            List<T> result = new List<T>();

            foreach (T item in this)
            {
                if (criteria(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
