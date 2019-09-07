using SocialApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace SocialApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
    }
}