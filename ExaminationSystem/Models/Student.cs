using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Models
{
    public class Student : User
    {
        public virtual List<ExamAttempt> Attempts { get; set; } = new();
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
