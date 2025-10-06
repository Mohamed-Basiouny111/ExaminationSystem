using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    [Table("Exam")]
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int NumberOfQuestions { get; set; }
        public TimeSpan Duration { get; set; }
        public ExamMode Mode { get; set; } = ExamMode.Queued;

        [ForeignKey("Subject")]
        public int? SubjectId { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual List<Question> Questions { get; set; } = new List<Question>();
      
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

    }
}
