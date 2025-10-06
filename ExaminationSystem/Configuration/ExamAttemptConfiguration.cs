using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.Configuration
{
    public class ExamAttemptConfiguration : IEntityTypeConfiguration<ExamAttempt>
    {
        public void Configure(EntityTypeBuilder<ExamAttempt> builder)
        {
            builder.HasOne(a => a.Student)
                    .WithMany(s => s.Attempts)
                    .HasForeignKey(a => a.StudentId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Exam)
                   .WithMany()
                   .HasForeignKey(a => a.ExamId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
