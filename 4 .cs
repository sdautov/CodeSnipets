using Newtonsoft.Json;
using System;

public class DefaultValueConverter<T> : JsonConverter where T : new()
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(T);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
        {
            return new T();  // 
        }

        //
        return serializer.Deserialize(reader, objectType);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }
}
