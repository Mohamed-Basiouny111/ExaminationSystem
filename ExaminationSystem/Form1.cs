using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Timer = System.Windows.Forms.Timer;

namespace ExaminationSystem
{
    public partial class FormName : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();

        private int examId = 6;
        private System.Windows.Forms.Timer examTimer;

        public FormName()
        {
            InitializeComponent();
            //db.Database.EnsureDeleted();
        }

        private void FormName_Load(object sender, EventArgs e)
        {
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            examTimer = new Timer();
            examTimer.Interval = 1000; // كل 60 ثانية (دقيقة)
            examTimer.Tick += ExamTimer_Tick;
            examTimer.Start();
        }
        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            CheckExamStatus();
        }
        private void CheckExamStatus()
        {
            try
            {
                using (var db = new ExaminationSystemContext())
                {
                    var exam = db.Exams.FirstOrDefault(x => x.Id == examId);
                    if (exam == null)
                        return;

                    // التشيك لو الامتحان بدأ
                    if (exam.Mode == ExamMode.Starting)
                    {
                        examTimer.Stop();
                        MessageBox.Show("📢 الامتحان بدأ الآن! بالتوفيق 👏", "إشعار الامتحان", MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                    }
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
