using System;
using System.Collections.Generic;

namespace DictionarySerializer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = new Dictionary<string, object>
            {
                {"key1", 1},
                {
                    "key2", new Dictionary<string, object>
                    {
                        {"key3", 1},
                        { "key4", new Dictionary<string, object>
                        {
                            {"key5", 4}
                        }
                        }
                    }
                }
            };
            var serializer = new Serializer();
            var serializedData = serializer.GetSerializedData(a);
            foreach (var data in serializedData)
            {
                Console.WriteLine(data);
            }

            Console.Read();
        }
    }
}
