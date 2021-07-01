using Microsoft.EntityFrameworkCore;

namespace TestingWebApp
{
    public class TestingWebDbContext : DbContext
    {
        public DbSet<TestEntity> TestEntities { get; set; }
    }
}
