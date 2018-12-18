using Newtonsoft.Json;

namespace HursingManage.WebServer.Common
{
    public static class JsonHelper
    {
        static JsonSerializerSettings jsonSeting = new JsonSerializerSettings()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        public static string ToJson(object obj)
        {
            string jsonStr = JsonConvert.SerializeObject(obj, jsonSeting);
            return jsonStr;
        }
        public static T JsonToObj<T>(string jsonStr)
        {
            T obj = JsonConvert.DeserializeObject<T>(jsonStr);
            return obj;
        }

        public static object JsonToObj(string jsonStr)
        {
            var obj = JsonConvert.DeserializeObject(jsonStr);
            return obj;
        }
    }
}