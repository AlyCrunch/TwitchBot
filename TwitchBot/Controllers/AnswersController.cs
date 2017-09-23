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
    [Route("api/v1/[controller]")]
    public class AnswersController : Controller
    {
        private readonly AnswerContext _context;
        public AnswersController(AnswerContext context)
        {
            _context = context;
            if (_context.AnswerItems.Count() == 0)
            {
                _context.AnswerItems.Add(new Answer { Name = "Oui", Value = "yes" });
                _context.AnswerItems.Add(new Answer { Name = "Non", Value = "no" });
                _context.SaveChanges();
            }
        }
        
        [HttpGet]
        public IEnumerable<Answer> GetAll()
        {
            return _context.AnswerItems.ToList();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Answer item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.AnswerItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetAnswer", new { id = item.Id }, item);
        }

        [HttpGet("{id}", Name = "GetAnswer")]
        public IActionResult Read(long id)
        {
            var item = _context.AnswerItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Answer item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var answer = _context.AnswerItems.FirstOrDefault(t => t.Id == id);
            if (answer == null)
            {
                return NotFound();
            }

            answer.Name = item.Name;
            answer.Value = item.Value;

            _context.AnswerItems.Update(answer);
            _context.SaveChanges();
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.AnswerItems.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.AnswerItems.Remove(todo);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
