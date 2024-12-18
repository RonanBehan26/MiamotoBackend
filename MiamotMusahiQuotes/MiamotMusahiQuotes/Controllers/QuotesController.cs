using MiamotMusahiQuotes.Models;
using Microsoft.AspNetCore.Mvc;

namespace MiamotMusahiQuotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private static readonly List<Quote> Quotes = new()
        {
            //new Quote { Id = 1, Content = "The only limit to our realization of tomorrow is our doubts of today." },
            //new Quote { Id = 2, Content = "Do not wait; the time will never be 'just right'. Start where you stand." },
            new Quote { Id = 2, Content = "Test." },
            // Add more quotes here
        };

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(Quotes);
        }
    }
}
