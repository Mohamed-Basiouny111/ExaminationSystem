using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Data
{
    public class ExaminationSystemContext : DbContext
    {
        //DbSet
        public DbSet<Exam> exams {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? connection_string = new ConfigurationBuilder().AddJsonFile("Connection.json").Build().GetSection("Connection").Value;
                if (!string.IsNullOrEmpty(connection_string))
                {
                    optionsBuilder.UseLazyLoadingProxies()
                     .UseSqlServer(connection_string);
                }
                else
                {
                    throw new InvalidOperationException("Connection string 'Connection' not found in Connection.json");
                }
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //All Assembly
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Exam).Assembly);
        }
    }
}
