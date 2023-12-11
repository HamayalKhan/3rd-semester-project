﻿using API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Auth.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class AuthController : Controller
    {
        private readonly ApiDbContext _context;
        public AuthController(ApiDbContext context)
        {
            _context = context;
        }

        //Get Protocol for all

        [HttpGet]
        public IEnumerable<User> GetData()
        {
            return _context.Users.ToList();
        }
        //Get Protocol Id based
        [HttpGet("id")]
        public IActionResult getdata(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);


        }

        //post protocol
        [HttpPost]
        public void postdata([FromBody] User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
        }

        //update protocol
        [HttpPut("{id}")]
        public void updatedata(int id, [FromBody] User UpdatedUser)
        {
            _context.Entry(UpdatedUser).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //delete protocol
        [HttpDelete("{id}")]
        public void deletedata(int id)
        {

            var user = _context.Users.FirstOrDefault(u => u.UserId == id);

            if (user == null)
            {
                NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();

            Ok();
        }

    }
}
