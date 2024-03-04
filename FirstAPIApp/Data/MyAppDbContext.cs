using FirstAPIApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPIApp.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employees> Employee { get; set; }
    }
}
