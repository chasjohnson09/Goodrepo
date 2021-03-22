using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoApp;

namespace ToDoLib.Models
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext() { }     //default constructor
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Category> Categories { get; set; }
        

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
    }
}
