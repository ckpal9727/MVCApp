using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MVCApp.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } // This will create the Users table
    }
}
