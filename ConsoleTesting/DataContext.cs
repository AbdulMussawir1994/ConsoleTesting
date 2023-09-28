using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class DataContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EntitiesDb;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=True;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public class Entity
        {
            [Key]
            public int MyProperty { get; set; }
            public required string Name { get; set; }
        }

    }
}
