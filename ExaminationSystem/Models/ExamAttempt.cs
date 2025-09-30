using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    [Table("ExamAttempt")]
    public class ExamAttempt
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public virtual Exam? Exam { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public virtual Student? Student { get; set; }

        public DateTime StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public double Score { get; set; }

        public virtual List<StudentAnswer> StudentAnswers { get; set; } = new List<StudentAnswer>();
    }
}
