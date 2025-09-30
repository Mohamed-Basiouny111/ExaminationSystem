using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public int Marks { get; set; }
        public virtual List<Answer> Answers { get; set; } = new List<Answer>();
        [ForeignKey("Exam")]
        public int? ExamId { get; set; } 
        public virtual Exam? Exam { get; set; }
    }
}
