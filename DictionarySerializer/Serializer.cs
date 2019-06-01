using System.Collections.Generic;

namespace DictionarySerializer
{
    public class Serializer
    {
        public List<string> GetSerializedData(Dictionary<string, object> dictionary)
        {
            return GetKeysWithLevel(dictionary, 1);
        }

        private static List<string> GetKeysWithLevel(Dictionary<string, object> dictionary, int level)
        {
            var result = new List<string>();
            foreach (var pair in dictionary)
            {
                result.Add($"{pair.Key} {level}");
                if (pair.Value is Dictionary<string, object>)
                    result.AddRange(GetKeysWithLevel(pair.Value as Dictionary<string, object>, level + 1));
            }
            return result;
        }
    }
}
