using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TwitchBot.Models
{
    public class Answer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
