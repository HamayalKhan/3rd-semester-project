using API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AwardController : Controller
    {
        private readonly ApiDbContext _context;
        public AwardController(ApiDbContext context)
        {
            _context = context;
        }

        //Get Protocol for all

        [HttpGet]
        public IEnumerable<Award> GetData()
        {
            return _context.Award.ToList();
        }
        //Get Protocol Id based
        [HttpGet("id")]
        public IActionResult getdata(int id)
        {
            var Award = _context.Award.FirstOrDefault(u => u.AwardId == id);
            if (Award == null)
            {
                return NotFound();
            }

            return Ok(Award);


        }

        //post protocol
        [HttpPost]
        public void postdata([FromBody] Award Award)
        {
            _context.Award.Add(Award);
            _context.SaveChanges();
        }

        //update protocol
        [HttpPut("{id}")]
        public void updatedata(int id, [FromBody] Award UpdatedAward)
        {
            _context.Entry(UpdatedAward).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //delete protocol
        [HttpDelete("{id}")]
        public void deletedata(int id)
        {

            var award = _context.Award.FirstOrDefault(u => u.AwardId == id);


            _context.Award.Remove(award);
            _context.SaveChanges();

            Ok();
        }
    }
}
