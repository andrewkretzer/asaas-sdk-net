using System.Collections.Generic;

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
    }
}
