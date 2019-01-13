using Newtonsoft.Json;
using System;
using System.Net;

namespace MyStrom.Api.Helpers
{
    public static class Reader<T>
    {
        public static T ReadObject(Uri uri)
        {
            using (var client = new WebClient())
            {
                var content = client.DownloadString(uri);

                var deserializerSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                return JsonConvert.DeserializeObject<T>(content, deserializerSettings);
            }
        }
    }
}