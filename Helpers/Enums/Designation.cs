using System.Text.Json.Serialization;

namespace Restaurant_Manage_Backened.Helpers.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Designation
    {
        Administration = 1,
        Chef = 2,
        Waitstaff = 3,
        Janitor = 4,
        Dishwasher = 5,
        Manager = 6,
        Kitchenhand = 7
    }
}