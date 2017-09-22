using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TwitchBot.Models
{
    public class Vote
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public long PollID { get; set; }
        public long AnswerID { get; set; }
    }
}
