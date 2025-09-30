using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Configuration
{
    public class StudentAnswerConfiguration : IEntityTypeConfiguration<StudentAnswer>
    {
        public void Configure(EntityTypeBuilder<StudentAnswer> builder)
        {
             builder.HasOne(sa => sa.Answer)
             .WithMany()
             .HasForeignKey(sa => sa.AnswerId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
