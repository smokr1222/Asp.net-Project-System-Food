using Newtonsoft.Json;

namespace systemFood.Session
{

    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            var json = System.Text.Json.JsonSerializer.Serialize(value);
            session.SetString(key, json);
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var json = session.GetString(key);
            return json == null ? default : System.Text.Json.JsonSerializer.Deserialize<T>(json);
        }
    }

}
