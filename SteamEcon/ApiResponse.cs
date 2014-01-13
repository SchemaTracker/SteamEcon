using Newtonsoft.Json;

namespace SteamEcon
{
    public class ApiResponse<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }
    }
}