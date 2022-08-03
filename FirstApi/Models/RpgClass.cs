using System.Text.Json.Serialization;

namespace FirstApi.Models
{
    // this is needed to see [knight, mage, cleric] instead of [1, 2, 3]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
    }
}
