using Microsoft.EntityFrameworkCore;
using MyCRUDProject.Models;

namespace MyCRUDProject.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<MyEntity> MyEntities { get; set; }
    }
}
