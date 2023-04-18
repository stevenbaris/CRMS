using Newtonsoft.Json;

namespace CRMS.Services._BackgroundServices.Token
{
    public class Tokens
    {
        [JsonProperty("token")]
        public string? AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public DateTimeOffset ExpiresIn { get; set; }

        [JsonIgnore]
        public DateTime ExpirationTime { get; set; }

        public bool IsExpired()
        {
            return DateTime.UtcNow >= ExpirationTime;
        }
    }
}
