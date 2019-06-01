using System.Collections.Generic;
using DictionarySerializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionarySerializerTests
{
    [TestClass()]
    public class SerializerTests
    {
        [TestMethod()]
        public void SerializedDataValidationTest()
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
            Assert.IsInstanceOfType(serializedData, typeof(List<string>));
            Assert.AreEqual(5, serializedData.Count);                         
        }
    }
}