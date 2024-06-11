using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CompareTwoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var charOld = DummyData.Character();
            //var charOld = DummyData.Character3();
            var charNew = DummyData.Character2();
            var dic1 = new Dictionary<string, object>();
            var dic2 = new Dictionary<string, object>();
            List<PropertyInfo> diffProperties = new List<PropertyInfo>();
            var allPropertiesOfCharOld = charOld.GetType().GetProperties();
            if (allPropertiesOfCharOld != null && allPropertiesOfCharOld.Any())
            {
                foreach (var item in allPropertiesOfCharOld)
                {
                    if (!Equals(item.GetValue(charOld), charNew.GetType().GetProperty(item.Name).GetValue(charNew)))
                    {
                        diffProperties.Add(item);
                    }
                }
            }

            if (diffProperties != null && diffProperties.Any())
            {
                foreach (var item in diffProperties)
                {
                    var value = item.GetValue(charNew);
                    var propName = item.Name;
                    dic1.Add(string.Format(propName), value);
                }
                if (dic1 != null && dic1.Any())
                {
                    dic2 = new Dictionary<string, object>(dic1);
                    foreach (var key in dic1.Keys)
                    {
                        foreach (var propInfo in allPropertiesOfCharOld)
                        {
                            if (key == propInfo.Name)
                            {
                                var value2 = propInfo.GetValue(charOld);
                                var propName2 = propInfo.Name;
                                dic2.Add(string.Format(propName2 + "old"), value2);
                            }
                        }
                    }
                }
            }

            if (dic2 != null && dic2.Any())
            {
                Console.WriteLine("Two object have different data");
                foreach (var item in dic2.OrderByDescending(x => x.Key))
                {
                    Console.WriteLine("{0}, value :{1}", item.Key, item.Value);
                }
            }
            else
            {
                Console.WriteLine("Two object are same data");
            }

            Console.ReadKey();
        }
    }
}
