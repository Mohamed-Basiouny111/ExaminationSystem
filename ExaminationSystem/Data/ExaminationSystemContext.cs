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
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<PracticeExam> PracticeExams { get; set; }
        public DbSet<FinalExam> FinalExams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<TrueFalseQuestion> TrueFalseQuestions { get; set; }
        public DbSet<ChooseOneQuestion> ChooseOneQuestions { get; set; }
        public DbSet<ChooseAllQuestion> ChooseAllQuestions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<ExamAttempt> ExamAttempts { get; set; }
        public DbSet<StudentAnswer> StudentAnswers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? connection_string = new ConfigurationBuilder().AddJsonFile("Connection.json").Build().GetSection("Connection").Value;
                if (!string.IsNullOrEmpty(connection_string))
                {
                    optionsBuilder
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
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Exam).Assembly);

         

            base.OnModelCreating(modelBuilder);
        }
    }
}
