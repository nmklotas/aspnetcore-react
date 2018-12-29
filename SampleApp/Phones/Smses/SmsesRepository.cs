using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Phones.Data;
using SampleApp.Phones.Extensions;
using Microsoft.EntityFrameworkCore;

namespace SampleApp.Phones.Smses
{
    public class SmsRepository
    {
        private readonly TspDatabaseContext _context;

        public SmsRepository(TspDatabaseContext context) 
            => _context = context;

        public async Task<IList<string>> Top5PhoneNumbersWithMostSms(DateTime from, DateTime to) 
            => await _context.Phones.Include(phone => phone.Smses).
            OrderByDescending(p => p.Smses.Count).
            Select(s => s.Number).
            Take(5).
            ToArrayAsync();

        public async Task<int> Total(DateTime from, DateTime to) 
            => await _context.Smses.
            Where(s => s.Date.Between(from, to)).
            CountAsync();
    }
}

