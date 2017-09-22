using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.TwitchBot.Models;
using API.TwitchBot.Models.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.TwitchBot.Controllers
{
    [Route("api/[controller]")]
    public class VotesController : Controller
    {
        private readonly VoteContext _context;
        public VotesController(VoteContext context)
        {
            _context = context;
            if (_context.VoteItems.Count() == 0)
            {
                _context.VoteItems.Add(new Vote { Date = DateTime.Now, PollID = 1, AnswerID = 2 });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Vote> GetAll()
        {
            return _context.VoteItems.ToList();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Vote item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            item.Date = DateTime.Now;
            _context.VoteItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetVote", new { id = item.Id }, item);
        }

        [HttpGet("{id}", Name = "GetVote")]
        public IActionResult Read(long id)
        {
            var item = _context.VoteItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Vote item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var vote = _context.VoteItems.FirstOrDefault(t => t.Id == id);
            if (vote == null)
            {
                return NotFound();
            }

            vote.AnswerID = item.AnswerID;
            vote.PollID = item.PollID;

            _context.VoteItems.Update(vote);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.VoteItems.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.VoteItems.Remove(todo);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
