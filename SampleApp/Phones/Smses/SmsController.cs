using System;
using System.Threading.Tasks;
using SampleApp.Phones.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace SampleApp.Phones.Smses
{
    [Route("api/sms")]
    public class SmsController : Controller
    {
        private readonly SmsRepository _smses;

        public SmsController(SmsRepository smses)
            => _smses = smses;

        [HttpGet("total")]
        public async Task<IActionResult> Total([FromQuery]DateTime? from, [FromQuery]DateTime? to) 
            => Ok(new TotalSmsResult(
                await _smses.Total(from.DefaultToMin(), to.DefaultToMax())));

        [HttpGet("top5/most")]
        public async Task<IActionResult> Top5PhoneNumbersWithMostSms([FromQuery]DateTime? from, [FromQuery]DateTime? to) 
            => Ok(new Top5PhoneNumbersByMostSmsResult(
                await _smses.Top5PhoneNumbersWithMostSms(from.DefaultToMin(), to.DefaultToMax())));
    }
}