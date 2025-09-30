using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    [Table("User")]
    public abstract class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public string PasswordHash { get; set; }
    }

    #region Department
    //public class Department
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    [Required]
    //    [MaxLength(100)]
    //    public string Name { get; set; }
    //    public virtual List<Student> Students { get; set; } = new List<Student>();
    //} 
    #endregion


}
