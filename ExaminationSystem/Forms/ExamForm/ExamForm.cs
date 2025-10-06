using DocumentFormat.OpenXml.Wordprocessing;
using ExaminationSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.ExamForm
{
    public partial class ExamForm : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        public ExamForm()
        {
            InitializeComponent();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            TodaysDatelabel.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
            //Noofquestionslabel.Text = db.Exams.FirstOrDefault(e => e.).NumberOfQuestions.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
