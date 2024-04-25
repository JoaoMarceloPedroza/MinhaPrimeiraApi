using System.Text.Json.Serialization;

namespace MinhaPrimeiraApi.Domain.Models.User
{
    public class UserRegisterRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("password")]
        public string Password { get; set; } = "";
        
        [JsonPropertyName("email")]        
        public string Email { get; set; } = "";

        [JsonPropertyName("birth_year")]
        public DateTime BirthYear { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
    }
}
