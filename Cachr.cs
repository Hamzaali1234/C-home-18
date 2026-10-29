static class Cache<T>
{
static Dictionary<string,T> data=new Dictionary<string,T>();
public static void Add(string key,T value)
{
    data[key] = value;
}
public static T Get(string key)
{
    if (data.ContainsKey(key))
    {
        return data[key];
    }
    return default(T);
}
public static void Remove(string key)
{
    data.Remove(key);
}
}