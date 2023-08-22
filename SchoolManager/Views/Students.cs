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
        #region ..:: Instances and Variables ::..
        Student student = new Student();
        Service service = new Service();
        #endregion

        #region ..:: Constructor ::..
        public Students()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..
        private void Students_Load(object sender, EventArgs e)
        {
            // Calling a class to fill ComboBox
            FillClassCombo();
            // Fill DataGridView
            LoadAllStudentsData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Fill DataGridView
            LoadAllStudentsData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Cleaning fields
            txtName.Text = string.Empty;
            cmbClass.SelectedIndex = 0;
            txtCPF.Text = string.Empty;
            dgvStudents.DataSource = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If we open students register, we load datagrid again to take new changes
            new StudentSettings().ShowDialog();
            LoadAllStudentsData();
        }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checking collumn clicked to define if is alteration or deleting routine
            if (e.ColumnIndex == dgvStudents.Columns["colEdit"].Index)
                if (MessageBox.Show("Deseja realmente editar esse aluno?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    new StudentSettings(student.Id).ShowDialog(); // if is alteration routine
                
            else if (e.ColumnIndex == dgvStudents.Columns["colDelete"].Index)
                if (MessageBox.Show("Deseja realmente excluir esse aluno?", "CUIDADO - EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    service.StudentDelete(student.Id); // if is deleting routine

            LoadAllStudentsData();
        }
        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            // Searching Id in selected line
            DataGridViewRow ActualLine = dgvStudents.CurrentRow;
            int row = ActualLine.Index;
            student.Id = Convert.ToInt32(dgvStudents.Rows[row].Cells[colId.Index].Value);
        }
        #endregion

        #region ..:: Other Methods ::..
        private void LoadAllStudentsData()
        {
            // Values attribution to properties and searching values on database to fill Datagrid
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
        #endregion
    }
}
