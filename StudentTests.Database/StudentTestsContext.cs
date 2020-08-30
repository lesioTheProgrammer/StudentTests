using Microsoft.EntityFrameworkCore;
using System;

namespace StudentTests.Database
{
    public class StudentTestsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6L3N6EN\LOCALHOST;Database=StudentTests;Trusted_Connection=True;");
        }

        // public DbSet<Type> Type properties bellow



        // fluentAPI onModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
