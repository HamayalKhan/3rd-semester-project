using Microsoft.EntityFrameworkCore;

namespace API.Model
{

    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }


        public DbSet<Staff> Staff { get; set; }

        public DbSet<Posting> Posting { get; set; }

        public DbSet<ExhibitionPosting> ExhibitionPosting { get; set; }

        public DbSet<Exhibition> Exhibition { get; set; }

        public DbSet<Competition> Competition { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Award> Award { get; set; }


    }
}

