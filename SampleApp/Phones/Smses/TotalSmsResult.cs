using Newtonsoft.Json;

namespace SampleApp.Phones.Smses
{
    public class TotalSmsResult
    {
        public TotalSmsResult(int total) 
            => Total = total;

        [JsonProperty("total")]
        public int Total { get; }
    }
}