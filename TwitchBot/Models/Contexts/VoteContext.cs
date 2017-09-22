using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TwitchBot.Models.Context
{
    public class VoteContext : DbContext
    {
        public VoteContext(DbContextOptions<VoteContext> options)
            : base(options)
        {
        }

        public DbSet<Vote> VoteItems { get; set; }
    }
}
