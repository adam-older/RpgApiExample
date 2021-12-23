using System;
using System.Text.Json.Serialization;

namespace RpgApiExample.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}
