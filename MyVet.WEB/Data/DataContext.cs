using Microsoft.EntityFrameworkCore;
using MyVet.Web.Data.Entities;
using MyVet.WEB.Data.Entities;

namespace MyVet.WEB.Data
{
   public class DataContext : DbContext
   {
      public DataContext(DbContextOptions<DataContext> options) : base(options)
      {
      }
      public DbSet<Owner> Owners { get; set; }
      public DbSet<PetType> PetTypes { get; set; }

      public DbSet<Pet> Pets { get; set; }

      public DbSet<ServiceType> ServiceTypes { get; set; }

      public DbSet<History> Histories { get; set; }

      public DbSet<Agenda> Agendas { get; set; }

   }

}

