using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Model
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options) { }
    }
}
