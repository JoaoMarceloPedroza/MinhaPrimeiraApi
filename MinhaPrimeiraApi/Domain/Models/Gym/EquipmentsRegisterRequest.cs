using System.Text.Json.Serialization;

namespace MinhaPrimeiraApi.Domain.Models.Gym
{
    public class EquipmentsRegisterRequest
    {
        [JsonPropertyName("equipment_name")] 
        public string EquipmentName { get; set; } = ""; 

        [JsonPropertyName("maximum_weight")]
        public decimal MaximumWeight { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
    }
}
