using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TwitchBot.Models.Context
{
    public class AnswerContext : DbContext
    {
        public AnswerContext(DbContextOptions<AnswerContext> options)
            : base(options)
        {
        }

        public DbSet<Answer> AnswerItems { get; set; }
    }
}
