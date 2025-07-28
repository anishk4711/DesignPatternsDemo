using System.Text.Json;

namespace DesignPatternsDemo.PrototypeDP
{
    public static class CloningExtention
    {
        public static T CloneWithSerialization<T>(this T obj) 
        {
            // Use serialization to create a deep copy of the object
            string jsonString = JsonSerializer.Serialize(obj);
            T clonedObject = JsonSerializer.Deserialize<T>(jsonString)!;
            return clonedObject;
        }
    }
}
