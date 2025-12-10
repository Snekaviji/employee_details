using Microsoft.EntityFrameworkCore;
using my_tech_bk.Models;

namespace my_tech_bk.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        public DbSet<EmployeeModels> Employees { get; set; } = null!;
    }
}
