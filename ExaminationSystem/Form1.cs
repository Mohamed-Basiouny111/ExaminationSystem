using ExaminationSystem.Data;

namespace ExaminationSystem
{
    public partial class FormName : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public FormName()
        {
            InitializeComponent();
            //db.Database.EnsureDeleted();
        }

        private void FormName_Load(object sender, EventArgs e)
        {

        }
    }
}
