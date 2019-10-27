using System.Collections.Generic;

namespace AsaasClient.Core
{
    public class Map
    {
        private readonly List<KeyValuePair<string, object>> keyValuePairList = new List<KeyValuePair<string, object>>();

        public int Count
        {
            get
            {
                return keyValuePairList.Count;
            }
        }

        public void Add(string key, object value)
        {
            var keyValuePair = new KeyValuePair<string, object>(key, value);
            keyValuePairList.Add(keyValuePair);
        }

        public KeyValuePair<string, object> Get(int index)
        {
            return keyValuePairList[index];
        }
    }
}
