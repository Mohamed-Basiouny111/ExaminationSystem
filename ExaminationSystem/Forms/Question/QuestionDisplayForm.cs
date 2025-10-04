using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using ExaminationSystem.Data;
using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExaminationSystem.Forms.Question
{
    public partial class QuestionDisplayForm : Form
    {
        private Models.Question _question;
        private int _questionId;


        public QuestionDisplayForm(Models.Question question)
        {
            InitializeComponent();

            _questionId = question.Id;


            txtHeader.Text = question.Header;
            rtbBody.Text = question.Body;
            txtMarks.Text = question.Marks.ToString();


            // Display answers
            if (question is TrueFalseQuestion)
                lstAnswers.SelectionMode = SelectionMode.One;
            else if (question is ChooseOneQuestion)
                lstAnswers.SelectionMode = SelectionMode.One;
            else if (question is ChooseAllQuestion)
                lstAnswers.SelectionMode = SelectionMode.MultiSimple;
            else
                lstAnswers.SelectionMode = SelectionMode.One; // default

            lstAnswers.Items.Clear();
            foreach (var answer in question.Answers)
            {
                int index = lstAnswers.Items.Add(answer.Text);
                if (answer.IsCorrect)
                    lstAnswers.SetSelected(index, true);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuestionDisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (var context = new ExaminationSystemContext())
            {
                var dbQuestion = context.Questions
                    .Include(q => q.Answers)
                    .FirstOrDefault(q => q.Id == _questionId); // safe id lookup

                if (dbQuestion == null) return;

                dbQuestion.Header = txtHeader.Text.Trim();
                dbQuestion.Body = rtbBody.Text.Trim();

                if (int.TryParse(txtMarks.Text.Trim(), out int marks))
                    dbQuestion.Marks = marks;
                else
                {
                    MessageBox.Show("Marks must be a number");
                    return;
                }

                // Sync answers
                foreach (var ans in dbQuestion.Answers)
                {
                    int index = lstAnswers.Items.IndexOf(ans.Text);
                    if (index >= 0)
                        ans.IsCorrect = lstAnswers.SelectedIndices.Contains(index);
                }

                context.SaveChanges();
            }

            MessageBox.Show("Question updated successfully!");

            this.Close();

        }
    }
}