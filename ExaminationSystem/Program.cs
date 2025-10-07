using ExaminationSystem.Forms.TeacherForn;
using ExaminationSystem.Forms.UsersForm;
using ExaminationSystem.Forms;
using ExaminationSystem.Forms.ExamForm;
using ExaminationSystem.Forms.Question;
using ExaminationSystem.Models;
using ExaminationSystem.Forms.ReportForms;

namespace ExaminationSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            Application.Run(new ChooseAllQuestionForm());


        }
    }
}