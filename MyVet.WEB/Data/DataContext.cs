using Microsoft.EntityFrameworkCore;
using MyVet.WEB.Data.Entities;

namespace MyVet.WEB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Owner> Owners { get; set; }
    }

}

