using System.Text.Json.Serialization;

namespace Restaurant_Manage_Backened.Helpers.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        Other = 1,
        Admin = 2,
        Kitchen = 3,
    }
}

