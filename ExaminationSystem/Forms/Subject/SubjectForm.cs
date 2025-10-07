using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using ExaminationSystem.BL.UserLayer;
using ExaminationSystem.Data;
using ExaminationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.Forms.Subject
{
    public partial class SubjectForm : Form
    {
        ExaminationSystemContext db = new ExaminationSystemContext();
        string story ="";
        int subid=0;

        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {

            Clear();

        }

        private void Clear()
        {
            dgvUser.DataSource = db.Subjects.Select(x => new
            {
                x.Id,
                x.Name
            }).OrderByDescending(e => e.Id).ToList();
            dgvUser.ClearSelection();
            txtSubjectName.Text = txtSearch.Text = story = "";
            txtSubjectName.Focus();
            txtSubjectName.Select();
            txtSubjectName.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || txtSubjectName.Text == "")
            {
                MessageBox.Show("Please enter a subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (story == "Edit")
            {
                var s = db.Subjects.Where(e=>e.Id != subid).FirstOrDefault(s => s.Name == txtSubjectName.Text);
                if (s != null)
                {
                    MessageBox.Show("This Subject Name Already Exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                var subj= db.Subjects.Find(subid);
                if(subj != null)
                {
                    subj.Name = txtSubjectName.Text;
                    db.SaveChanges();
                    MessageBox.Show("Updated Successful", "Successful Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                var s = db.Subjects.FirstOrDefault(s => s.Name == txtSubjectName.Text);
                if (s != null)
                {
                    MessageBox.Show("This Subject Name Already Exists", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }   

                Models.Subject su = new Models.Subject();
                su.Name = txtSubjectName.Text;
                db.Subjects.Add(su);
                db.SaveChanges();
                MessageBox.Show("Save Successful", "Successful Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

               
            Clear();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a subject name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvUser.DataSource = db.Subjects.Select(x => new
            {
                x.Id,
                x.Name

            }).Where(c => c.Name.Contains(txtSearch.Text)).ToList();


        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Clear();
        }

        int j = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            j++;
            dgvUser.DataSource = db.Subjects.Select(x => new
            {
                x.Id,
                x.Name
            }).OrderByDescending(x => x.Id).Skip(j * 100).Take(100).ToList();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            j = Math.Max(j - 1, 0);
            dgvUser.DataSource = db.Subjects.Select(x => new
            {
                x.Id,
                x.Name
            }).OrderByDescending(x => x.Id).Skip(j * 100).Take(100).ToList();
        }

        private void btnDSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { FileName = "ExportedData", DefaultExt = "xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Export");

                        // العناوين
                        for (int i = 0; i < dgvUser.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).Value = dgvUser.Columns[i].HeaderText;
                        }

                        // البيانات
                        for (int r = 0; r < dgvUser.Rows.Count; r++)
                        {
                            for (int c = 0; c < dgvUser.Columns.Count; c++)
                            {
                                worksheet.Cell(r + 2, c + 1).Value = dgvUser.Rows[r].Cells[c].Value?.ToString();
                            }
                        }

                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Successfully");
                    }
                }
            }
        }

        private void txtSubjectName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvUser.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are You Sure Delete User", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        subid = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["id"].Value);
                        var result = db.Subjects.Find(subid);
                        if (result != null)
                        {
                            db.Subjects.Remove(result);
                            db.SaveChanges();
                            MessageBox.Show($"Subject Deleted Successfully ", "Successfully Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delete Subject Failed", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Clear();
                }

                if (dgvUser.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    subid = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["id"].Value);

                    var result = db.Subjects.Find(subid);
                    txtSubjectName.Text = result.Name;
                    txtSubjectName.Focus();
                    story = "Edit";

                }

            }
            catch (Exception)
            {
                return;
            }

        }
    }
}
