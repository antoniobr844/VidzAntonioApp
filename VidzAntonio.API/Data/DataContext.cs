
using Microsoft.EntityFrameworkCore;
using VidzAntonio.API.Models;

namespace VidzAntonio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options){ }

        public DbSet<Value> Value  { get; set; }
            
    }
}