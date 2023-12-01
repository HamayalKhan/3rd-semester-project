using Microsoft.EntityFrameworkCore;

namespace API.Model
{

    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
    }
}

