using API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ExhibitionController : Controller
    {
        private readonly ApiDbContext _context;
        public ExhibitionController(ApiDbContext context)
        {
            _context = context;
        }

        //Get Protocol for all

        [HttpGet]
        public IEnumerable<Exhibition> GetData()
        {
            return _context.Exhibition.ToList();
        }
        //Get Protocol Id based
        [HttpGet("id")]
        public IActionResult getdata(int id)
        {
            var Exhibition = _context.Exhibition.FirstOrDefault(u => u.ExhibitionId == id);
            if (Exhibition == null)
            {
                return NotFound();
            }

            return Ok(Exhibition);


        }

        //post protocol
        [HttpPost]
        public void postdata([FromBody] Exhibition Exhibition)
        {
            _context.Exhibition.Add(Exhibition);
            _context.SaveChanges();
        }

        //update protocol
        [HttpPut("{id}")]
        public void updatedata(int id, [FromBody] Exhibition UpdatedExhibition)
        {
            _context.Entry(UpdatedExhibition).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //delete protocol
        [HttpDelete("{id}")]
        public void deletedata(int id)
        {

            var Exhibition = _context.Exhibition.FirstOrDefault(u => u.ExhibitionId == id);


            _context.Exhibition.Remove(Exhibition);
            _context.SaveChanges();

            Ok();
        }
    }
}
