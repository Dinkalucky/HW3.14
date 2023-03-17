using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    public static class ExtensionClass
    {
        
        public static IEnumerable<int> GetArray(this IEnumerable list)
        {
            List<int> list1 = new List<int>();

            foreach (var item in list)
            {
                list1.Add((int)item);
            }

            return list1;
        }
    }
}
