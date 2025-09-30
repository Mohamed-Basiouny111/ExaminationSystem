using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasOne(q => q.Exam)
            .WithMany(e => e.Questions)
            .HasForeignKey(q => q.ExamId)
            .OnDelete(DeleteBehavior.SetNull);

            builder.HasDiscriminator<string>("QuestionType")
            .HasValue<TrueFalseQuestion>("TrueFalse")
            .HasValue<ChooseOneQuestion>("ChooseOne")
            .HasValue<ChooseAllQuestion>("ChooseAll");
        }
    }
}
