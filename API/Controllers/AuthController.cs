using API.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    namespace Webapi.Controllers
    {
        [ApiController]
        [Route("Api")]
        public class ApiController : Controller
        {
            private readonly ApiDbContext _context;
           
        }
    }
}
