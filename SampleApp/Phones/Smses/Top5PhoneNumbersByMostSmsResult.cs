using System.Collections.Generic;
using Newtonsoft.Json;

namespace SampleApp.Phones.Smses
{
    public class Top5PhoneNumbersByMostSmsResult
    {
        public Top5PhoneNumbersByMostSmsResult(IList<string> numbers) 
            => Numbers = numbers;

        [JsonProperty("numbers")]
        public IList<string> Numbers { get; }
    }
}