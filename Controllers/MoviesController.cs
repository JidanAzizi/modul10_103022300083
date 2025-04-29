using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300083.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public static readonly List<Movies> moviesL = new List<Movies>
        {
            new Movies("The Shadshank Redemption", "Frank Darabont", ["Tim Robbins", "Morgan Freeman", "Bob Gunton"], "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movies("The Godfather", "Francis Ford Cappola", ["Marlon Brandon", "Al Pacino", "James Caan"], "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movies("The Dark Knght", "Christopher Nolan", ["Christian Bale", "Heath Ledger", "Aaron Eckhart"], "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        [HttpGet]

        public IEnumerable<Movies> Get()
        { 
            return moviesL;
        }

        [HttpGet("{index}")]

        public Movies Get(int index)
        { 
        return moviesL[index];
        }

        [HttpPost]

        public void Post([FromBody] Movies value)
        { 
            moviesL.Add(value);
        }

        [HttpDelete("{index}")]

        public void Delete(int index) {
            moviesL.RemoveAt(index);
        }
    }
}
