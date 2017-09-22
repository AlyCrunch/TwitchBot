using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TwitchBot.Models.Context
{
    public class PollContext : DbContext
    {
        public PollContext(DbContextOptions<PollContext> options)
            : base(options)
        {
        }

        public DbSet<Poll> PollItems { get; set; }
    }
}
