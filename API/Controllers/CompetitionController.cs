using API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CompetitionController : Controller
    {
        private readonly ApiDbContext _context;
        public CompetitionController(ApiDbContext context)
        {
            _context = context;
        }

        //Get Protocol for all

        [HttpGet]
        public IEnumerable<Competition> GetData()
        {
            return _context.Competition.ToList();
        }
        //Get Protocol Id based
        [HttpGet("id")]
        public IActionResult getdata(int id)
        {
            var Competition = _context.Competition.FirstOrDefault(u => u.CompetitionId == id);
            if (Competition == null)
            {
                return NotFound();
            }

            return Ok(Competition);


        }

        //post protocol
        [HttpPost]
        public void postdata([FromBody] Competition Competition)
        {
            _context.Competition.Add(Competition);
            _context.SaveChanges();
        }

        //update protocol
        [HttpPut("{id}")]
        public void updatedata(int id, [FromBody] Competition UpdatedCompetition)
        {
            _context.Entry(UpdatedCompetition).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //delete protocol
        [HttpDelete("{id}")]
        public void deletedata(int id)
        {

            var Competition = _context.Competition.FirstOrDefault(u => u.CompetitionId == id);


            _context.Competition.Remove(Competition);
            _context.SaveChanges();

            Ok();
        }
    }
}
