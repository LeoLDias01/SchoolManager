using SchoolManager.Controllers;
using SchoolManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager.Views
{
    public partial class Students : Workspace
    {
        Student student = new Student();
        Service service = new Service();
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            FillClassCombo();
            LoadAllStudentsData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAllStudentsData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            cmbClass.SelectedIndex = 0;
            txtCPF.Text = string.Empty;
            dgvStudents.DataSource = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new StudentSettings().ShowDialog();
            LoadAllStudentsData();
        }
        private void LoadAllStudentsData()
        {
            ValueAttribution();
            dgvStudents.DataSource = null;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.DataSource = service.LoadAllStudentsData(student);
        }
        private void ValueAttribution()
        {
            student.Name = txtName.Text;
            student.ClassId = Convert.ToInt32(cmbClass.SelectedValue);
            student.CPF = txtCPF.Text;
        }
        private void FillClassCombo()
        {
            service.FillClassCombo(ref cmbClass);
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStudents.Columns["colEdit"].Index)
            {
                if (MessageBox.Show("Deseja realmente editar esse aluno?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new StudentSettings(student.Id).ShowDialog();
                    LoadAllStudentsData();
                }
            }
            else if (e.ColumnIndex == dgvStudents.Columns["colDelete"].Index)
            {
                if (MessageBox.Show("Deseja realmente excluir esse aluno?", "CUIDADO - EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.StudentDelete(student.Id);
                    LoadAllStudentsData();
                }
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow ActualLine = dgvStudents.CurrentRow;
            int row = ActualLine.Index;
            student.Id = Convert.ToInt32(dgvStudents.Rows[row].Cells[colId.Index].Value);
        }
    }
}
