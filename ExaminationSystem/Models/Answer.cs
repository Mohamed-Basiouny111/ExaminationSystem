using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    [Table("Answer")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; } 
        [Required]
        public bool IsCorrect { get; set; }

        [ForeignKey("Question")]
        public int? QuestionId { get; set; }
        public virtual Question? Question { get; set; }
    }
}
