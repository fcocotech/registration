using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace registration.Models
{
    public class CMSContext : DbContext
    {
        public DbSet<UserModel> User { get; set; }
        public DbSet<CustomerModel> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=registration;user=root;password=''");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<UserModel>(entity =>
            //{   
            //    entity.HasKey(e => e.id);
            //    //entity.Property(e => e.fname).IsRequired();
            //});

            //modelBuilder.Entity<CustomerModel>(entity =>
            //{
            //    entity.HasKey(e => e.id);
            //    //entity.Property(e => e.Title).IsRequired();
            //    //entity.HasOne(d => d.Publisher)
            //      //.WithMany(p => p.Books);
            //});
        }
    }
}
