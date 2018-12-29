using System;
using SampleApp.Phones.Data;
using Microsoft.EntityFrameworkCore;

namespace SampleApp.Test.Phones.Data
{
    public class TestTspDatabaseContext
    {
        public TspDatabaseContext InMemory() => 
            new TspDatabaseContext(
                new DbContextOptionsBuilder<TspDatabaseContext>().
                    UseInMemoryDatabase(Guid.NewGuid().ToString()).
                    Options);
    }
}
