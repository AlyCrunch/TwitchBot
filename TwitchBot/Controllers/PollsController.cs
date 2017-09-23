using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using API.TwitchBot.Models;
using API.TwitchBot.Models.Context;

namespace API.TwitchBot.Controllers
{
    [Route("api/v1/[controller]")]
    public class PollsController : Controller
    {
        private readonly PollContext _context;

        public PollsController(PollContext context)
        {
            _context = context;

            if (_context.PollItems.Count() == 0)
            {
                _context.PollItems.Add(new Poll { Title = "Prout", Date = DateTime.Now });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Poll> GetAll()
        {
            return _context.PollItems.ToList();
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] Poll item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            
            item.Date = DateTime.Now;

            _context.PollItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetPoll", new { id = item.Id }, item);
        }

        [HttpGet("{id}", Name = "GetPoll")]
        public IActionResult Read(long id)
        {
            var item = _context.PollItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Poll item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var poll = _context.PollItems.FirstOrDefault(t => t.Id == id);
            if (poll == null)
            {
                return NotFound();
            }

            poll.Title = item.Title;
            poll.Answers = item.Answers;

            _context.PollItems.Update(poll);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.PollItems.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.PollItems.Remove(todo);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
