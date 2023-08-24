using System.Text.Json.Serialization;

namespace YatingTtsClient.Dto
{
    public class ResponseDto
    {
        [JsonPropertyName("audioContent")]
        public string AudioContent { get; set; }
        [JsonPropertyName("audioConfig")]
        public AudioConfigDto AudioConfig { get; set; }
    }
}


