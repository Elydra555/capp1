using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Models.People;

namespace ConsoleApp2.Data
{
    public class Context : DbContext
    {
        public DbSet<User> User { get; set; }
        public string ConnectionString { get; set; }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MsSqlLocalDb;Database=Benedek;Trusted_Connection=true");
        }
    }
}
