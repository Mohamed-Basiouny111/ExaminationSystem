using ExaminationSystem.Data;

namespace ExaminationSystem
{
    public partial class Form1 : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public Form1()
        {
            InitializeComponent();
            //db.Database.EnsureDeleted();
        }
    }
}
