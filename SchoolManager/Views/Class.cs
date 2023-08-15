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
    public partial class Class : Workspace
    {
        public int classId = 0;
        Classroom classroom = new Classroom();
        Service service = new Service();
        public Class()
        {
            InitializeComponent();
        }

        private void Class_Load(object sender, EventArgs e)
        {
            FillTermCombo();
            LoadAllClassData();
        }
        private void FillTermCombo() 
        {
            service.FillTermCombo(ref cmbTerm);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new ClassSettings().ShowDialog();
            LoadAllClassData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClass.Text = string.Empty;
            cmbTerm.SelectedIndex = 0;
            dgvClass.DataSource = null;
        }
        private void LoadAllClassData() 
        {
            ValueAttribution();
            dgvClass.DataSource = null;
            dgvClass.AutoGenerateColumns = false;
            dgvClass.DataSource = service.LoadAllClassData(classroom);
        }
        private void ValueAttribution()
        {
            classroom.Name = txtClass.Text;
            classroom.Term = Convert.ToInt32(cmbTerm.SelectedValue);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAllClassData();
        }

        private void dgvClass_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow ActualLine = dgvClass.CurrentRow;
            int row = ActualLine.Index;
            classId = Convert.ToInt32(dgvClass.Rows[row].Cells[colId.Index].Value);
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClass.Columns["colEdit"].Index)
            {
                if (MessageBox.Show("Deseja realmente alterar essa turma?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new ClassSettings(classId).ShowDialog();
                    LoadAllClassData();
                }
            }
            else if (e.ColumnIndex == dgvClass.Columns["colDelete"].Index)
            {
                if (MessageBox.Show("Deseja realmente excluir essa turma?", "CUIDADO - EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.DeleteClass(classId);
                    LoadAllClassData();
                }
            }
        }
    }
}
