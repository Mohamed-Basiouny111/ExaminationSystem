using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    [Table("StudentAnswer")]
    public class StudentAnswer
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ExamAttempt")]
        public int? ExamAttemptId { get; set; }
        public virtual ExamAttempt? ExamAttempt { get; set; }
        [ForeignKey("Question")]
        public int? QuestionId { get; set; }
        public virtual Question? Question { get; set; }
        [ForeignKey("Answer")]
        public int? AnswerId { get; set; }   
        public virtual Answer? Answer { get; set; }
        public DateTime AnsweredAt { get; set; } = DateTime.UtcNow;
    }
}
