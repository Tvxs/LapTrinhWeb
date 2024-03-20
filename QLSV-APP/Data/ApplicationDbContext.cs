using Microsoft.EntityFrameworkCore;
using WEBAPP.Models;

namespace WEBAPP.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<congviec> Congviecs { get; set; }


        
    }
}