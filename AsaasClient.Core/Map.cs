using System.Collections.Generic;
using System.Linq;

namespace AsaasClient.Core
{
    public class Map : Dictionary<string, string>
    {
        public void Add(string key, object value)
        {
            base.Add(key, value.ToString());
        }

        public void Add(string key, List<string> valueList)
        {
            foreach (var value in valueList)
            {
                Add(key, value);
            }
        }

        public void AddRange(Map map)
        {
            map.Keys.ToList().ForEach(key => Add(key, map[key]));
        }

        public new string this[string key]
        {
            get
            {
                if (ContainsKey(key))
                {
                    return this[key];
                }

                return null;
            }
        }
    }
}
