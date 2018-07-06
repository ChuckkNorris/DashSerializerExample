using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Web;

namespace DashSerializer
{
    class Program
    {
      
        static void Main(string[] args)
        {
            // URL encode all JSON string properties
            string encodedDashDescription = UrlEncodeJsonStringProperties(TestData.DashDescriptionJson);
            // Log dash description with URL encoded strings
            Console.WriteLine(encodedDashDescription);
            // URL decode all JSON string properties
            string decodedDashDescription = UrlEncodeJsonStringProperties(encodedDashDescription, shouldDecode: true);
            Console.WriteLine(decodedDashDescription);
            Console.ReadKey();
        }

        private static string UrlEncodeJsonStringProperties(string json, bool shouldDecode = false) {
            dynamic dashDescription = JsonConvert.DeserializeObject<dynamic>(json);
            // Iterate over all root properties
            foreach (JProperty jProp in dashDescription) {
                EncodeStringProperties(jProp, shouldDecode);
            }
            return JsonConvert.SerializeObject(dashDescription);
        }

        private static void EncodeStringProperties(JProperty jProp, bool shouldDecode) {
            if (jProp.HasValues && jProp.Value.Type == JTokenType.String) {
                // Check if property value is a string and encode it
                jProp.Value = shouldDecode ? HttpUtility.UrlDecode(jProp.Value.ToString()) : HttpUtility.UrlEncode(jProp.Value.ToString());
            } else if (jProp.HasValues) {
                // Iterate all child properties
                EncodeStringChildProperties(jProp, shouldDecode);
            }
        }

        private static void EncodeStringChildProperties(JToken jtoken, bool shouldDecode) {
            foreach (JToken childJProp in jtoken.Children()) {
                if (childJProp is JProperty) {
                    // If token is a JSON property, check if it's a string and encode it
                    EncodeStringProperties(childJProp as JProperty, shouldDecode);
                } else {
                    // Continue iterating through the children if it's not a property
                    EncodeStringChildProperties(childJProp, shouldDecode);
                }
            }
        }
    }
}
