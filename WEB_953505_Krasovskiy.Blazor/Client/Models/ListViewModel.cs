using System.Text.Json.Serialization;

namespace WEB_953505_Krasovskiy.Blazor.Client.Models
{
    public class ListViewModel
    {
        [JsonPropertyName("dishId")]
        public int DishId { get; set; }

        [JsonPropertyName("dishName")]
        public string DishName { get; set; }
    }
}
