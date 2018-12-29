using Newtonsoft.Json;

namespace SampleApp.Phones.Calls
{
    public class TotalCallsResult
    {
        public TotalCallsResult(int total)
            => Total = total;

        [JsonProperty("total")]
        public int Total { get; }
    }
}
