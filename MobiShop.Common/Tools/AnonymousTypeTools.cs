using System;
using System.Collections.Generic;
using System.Linq;

namespace MobiShop.Common.Tools
{
    public class AnonymousTypeTools
    {
        public static IDictionary<string, object> GetDictionary(object obj)
        {
            var dict = new Dictionary<string, object>();
            if (obj != null)
            {
                foreach (var property in obj.GetType().GetProperties())
                {
                    if (property.CanRead)
                        dict.Add(property.Name, property.GetValue(obj));
                }
            }
            return dict;
        }
    }
}
