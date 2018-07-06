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
            string encodedDashDescription = UrlEncodeDashDescription(TestData.DashDescriptionJson);
            // Log dash description with URL encoded strings
            Console.WriteLine(encodedDashDescription);
            Console.ReadKey();
        }

        private static string UrlEncodeDashDescription(string dashDescriptionJson) {
            dynamic dashDescription = JsonConvert.DeserializeObject<dynamic>(dashDescriptionJson);
            // Iterate over all root properties
            foreach (JProperty jProp in dashDescription) {
                EncodeStringProperties(jProp);
            }
            return JsonConvert.SerializeObject(dashDescription);
        }

        private static void EncodeStringProperties(JProperty jProp) {
            if (jProp.HasValues && jProp.Value.Type == JTokenType.String) {
                // Check if property value is a string and encode it
                jProp.Value = HttpUtility.UrlEncode(jProp.Value.ToString());
            } else if (jProp.HasValues) {
                // Iterate all child properties
                EncodeStringChildProperties(jProp);
            }
        }

        private static void EncodeStringChildProperties(JToken jtoken) {
            foreach (JToken childJProp in jtoken.Children()) {
                if (childJProp is JProperty) {
                    // If token is a JSON property, check if it's a string and encode it
                    EncodeStringProperties(childJProp as JProperty);
                } else {
                    // Continue iterating through the children if it's not a property
                    EncodeStringChildProperties(childJProp);
                }
            }
        }
    }
}
