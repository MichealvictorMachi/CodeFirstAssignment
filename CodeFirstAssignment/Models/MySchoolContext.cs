using EntityFramework.Exceptions.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment.Models
{
    public class MyDbContext :DbContext
    {
        public MyDbContext()
        {

        }
        public MyDbContext(DbContextOptions<MyDbContext> options)
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Admission> Audiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseExceptionProcessor();
                optionsBuilder.UseSqlServer("Server=.;Database=SQLContactsDB;Trusted_Connection=True;TrustServerCertificate=true; ");
            }
        }
    }
    
}
