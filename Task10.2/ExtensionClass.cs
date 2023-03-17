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

            foreach (var item in list)
            {
                yield return (int)item;
            }
            
        }
    }
}
