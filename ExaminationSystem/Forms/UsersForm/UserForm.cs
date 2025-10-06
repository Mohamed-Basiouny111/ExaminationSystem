using Castle.Components.DictionaryAdapter.Xml;
using ClosedXML.Excel;
using ExaminationSystem.BL.UserLayer;
using ExaminationSystem.Models;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExaminationSystem.Forms.UsersForm
{
    public partial class UserForm : Form
    {
        string story = "";
        int userId = 0;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
         
            cbxUserType.SelectedIndex = 0;
            txtFullName.Text = txtUserName.Text = txtSearch.Text = txtPassword.Text = story = "";

            dgvUser.DataSource = UserLayerBL.getAllUsers().OrderByDescending(x => x.Id).Take(50).ToList();
            dgvUser.ClearSelection();
            userId = 0;
            txtFullName.Focus();
            txtFullName.Select();
            txtFullName.SelectAll();
        }
        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cbxUserType.Focus();
                cbxUserType.Select();
                cbxUserType.SelectAll();
            }
        }

        private void cbxUserType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtUserName.Focus();
                txtUserName.Select();
                txtUserName.SelectAll();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.Select();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
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

        int j = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            j++;
            dgvUser.DataSource = UserLayerBL.getAllUsers().OrderByDescending(x => x.Id).Skip(j * 50).Take(50).ToList();

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            j = Math.Max(j - 1, 0);
            dgvUser.DataSource = UserLayerBL.getAllUsers().OrderByDescending(x => x.Id).Skip(j * 50).Take(50).ToList();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && cbxUserType.Text != "")
            {
                if (story == "Edit")
                {
                    var x = UserLayerBL.UpdateUser(userId, txtFullName.Text, txtUserName.Text, txtPassword.Text, cbxUserType.Text);
                    if (x >= 1)
                    {
                        MessageBox.Show($"User Updated Successfully ", "Successfully Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"User Name Is Exist ", "InValid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    }
                }
                else
                {
                    var x = UserLayerBL.InsertUser(txtFullName.Text, txtUserName.Text, txtPassword.Text, cbxUserType.Text);
                    if (x >= 1)
                    {
                        MessageBox.Show($"User Added Successfully ", "Successfully Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"User Name Is Exist ", "InValid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Complete Your Data", "InValid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                return;
            }
            Clear();
        }

        public string Decrypt(string encodedData)
        {
            byte[] decode = Convert.FromBase64String(encodedData);
            string decodedString = Encoding.UTF8.GetString(decode);
            return decodedString;
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
                        userId = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["id"].Value);
                        var result = UserLayerBL.DeleteUser(userId);
                        if (result >= 0)
                        {
                            MessageBox.Show($"User Deleted Successfully ", "Successfully Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delete User Failed", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Clear();
                }

                if (dgvUser.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    userId = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["id"].Value);
                    var result = UserLayerBL.GetUserById(userId);
                    txtFullName.Text = result.FullName;
                    txtPassword.Text = Decrypt(result.PasswordHash);
                    txtUserName.Text = result.UserName;
                    cbxUserType.Text = result.Role;
                    story = "Edit";

                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show($"Complete Your Data", "InValid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                return;
            }

            if (!int.TryParse(txtSearch.Text, out int id))
            {
                dgvUser.DataSource = UserLayerBL.SearchUserByName(txtSearch.Text).ToList();
            }
            else
            {
                dgvUser.DataSource = UserLayerBL.SearchUserById(id).ToList();

            }
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


    }
}
