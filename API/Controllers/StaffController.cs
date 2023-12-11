using API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class StaffController : Controller
    {
      /*  private readonly ApiDbContext _context;
        public Controller(ApiDbContext context)
        {
            _context = context;
        }

        //Get Protocol for all

        [HttpGet]
        public IEnumerable<> GetData()
        {
            return _context.Award.ToList();
        }
        //Get Protocol Id based
        [HttpGet("id")]
        public IActionResult getdata(int id)
        {
            var = _context.Award.FirstOrDefault(u => u.Id == id);
            if ( == null)
            {
                return NotFound();
            }

            return Ok(Award);


        }

        //post protocol
        [HttpPost]
        public void postdata([FromBody] class class)
        {
            _context..Add();
            _context.SaveChanges();
        }

    //update protocol
    [HttpPut("{id}")]
    public void updatedata(int id, [FromBody] Updated)
    {
        _context.Entry(Updated).State = EntityState.Modified;
        _context.SaveChanges();
    }

    //delete protocol
    [HttpDelete("{id}")]
    public void deletedata(int id)
    {

        var = _context..FirstOrDefault(u => u.Id == id);


        _context..Remove();
        _context.SaveChanges();

        Ok();
    }*/
}
}
