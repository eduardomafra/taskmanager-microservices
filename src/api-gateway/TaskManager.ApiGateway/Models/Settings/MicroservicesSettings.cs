using System.Text.Json.Serialization;

namespace TaskManager.ApiGateway.Models.Settings
{
    public class MicroservicesSettings
    {
        [JsonPropertyName("User")]
        public UserSettings User { get; set; }
        [JsonPropertyName("Task")]
        public TaskSettings Task { get; set; }

        public class UserSettings
        {
            [JsonPropertyName("Uri")]
            public string Uri { get; set; }
            [JsonPropertyName("SecretKey")]
            public string SecretKey { get; set; }
        }

        public class TaskSettings
        {
            [JsonPropertyName("Uri")]
            public string Uri { get; set; }
            [JsonPropertyName("SecretKey")]
            public string SecretKey { get; set; }
        }
    }
}
