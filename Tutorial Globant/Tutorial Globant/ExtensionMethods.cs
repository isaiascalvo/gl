using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial_Globant
{
    public static class ExtensionMethods
    {
        public static List<T2> MapCollection<T1,T2>(this List<T1> collection1, Func<T1, T2> mapFunction)
        {
            List<T2> collection2 = new List<T2>();
            foreach (var item in collection1)
            {
                collection2.Add(mapFunction.Invoke(item));
            }

            return collection2;
        }
    }
}
