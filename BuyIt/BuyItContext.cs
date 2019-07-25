using BuyIt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyIt
{
    public class BuyItContext:DbContext
    {
        public BuyItContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //db bağlantısı vb database instance ını ilgilendiren ince ayarlar
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=BuyIt;User Id=sa;Password =123; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //database şeması uygulanırken kullanılacak kural setleri
            //modelBuilder.Entity<User>().Property(a => a.EMail).IsRequired();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
