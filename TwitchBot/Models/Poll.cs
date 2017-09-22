using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TwitchBot.Models
{
    public class Poll
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public List<Answer> Answers { get; set; }
        public DateTime Date { get; set; }
    }
}
