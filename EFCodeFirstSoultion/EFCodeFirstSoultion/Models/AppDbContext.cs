using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstSoultion.Models
{
    public class AppDbContext : DbContext      // class is inside of the models folder in solution explorer -- Dbcontext is inherited 
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Orderline> Orderlines { get; set; }
        public AppDbContext() { }       //default constructor 

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)  // if the builder is not configured
            {
                var connStrg = "server=localhost\\sqlexpress;" +    // setting the connection to the database
                                "database=AppDb1;" +
                                "trusted_connection=true;";
                builder.UseSqlServer(connStrg); // tell c sharp that we are using that server even thogh it is not created yet
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>(cust =>        // this is how to set up a uique key inside of the column for the table
            {
                cust.HasIndex(x => x.Code).IsUnique(true);  // setting the code for customer to be a unique key (primary key)
            });
        }
    }
}
