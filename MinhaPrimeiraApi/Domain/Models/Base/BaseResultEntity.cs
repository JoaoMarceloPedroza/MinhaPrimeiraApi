using System.Text.Json.Serialization;

namespace MinhaPrimeiraApi.Domain.Models.Base
{
    public class BaseResultEntity
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonIgnore]
        public object? Object { get; set; }
    }
}
