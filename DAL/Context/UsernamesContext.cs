using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    internal class UsernamesContext : DbContext
    {
        public UsernamesContext() 
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }
        }

        public DbSet<Usernames> Usernames { get; set; } 


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-1HBRDEF2\\SQLEXPRESS;Initial Catalog=UsernamesEmailsAddresses;Integrated Security=SSPI; TrustServerCertificate=true");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usernames>().HasData(new Usernames[]
            {
                new Usernames{UserId= 1,Username="Jakob"},
                new Usernames{UserId= 2,Username="Jens"},
                new Usernames{UserId= 3,Username="Niklas"}
            });
        }

        public DbSet<Emails> Emails { get; set; }
        public DbSet<Addresses> Addresses { get; set; }
    }
}
