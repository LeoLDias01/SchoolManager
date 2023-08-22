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
    public partial class Attendant : Workspace
    {
        #region ..:: Instances and Variables ::..
        public Service service = new Service();
        public AttendantData attendant = new AttendantData();
        #endregion

        #region ..:: Constructor ::..
        public Attendant()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..
        private void Attendant_Load(object sender, EventArgs e)
        {
            // Calling a class to fill ComboBox
            FillClassCombo();
            // Fill DataGridView
            LoadAllAttendantData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AttendantSettings().ShowDialog();
            LoadAllAttendantData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Date validation
            if((dtpInitial.Checked == true && dtpFinal.Checked == true) || (dtpInitial.Checked == false && dtpFinal.Checked == false)) LoadAllAttendantData();
            else MessageBox.Show("As duas datas precisam estar ativas", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void dgvAttendant_SelectionChanged(object sender, EventArgs e)
        {
            // Searching Id in selected line
            DataGridViewRow ActualLine = dgvAttendant.CurrentRow;
            int row = ActualLine.Index;
            attendant.Id = Convert.ToInt32(dgvAttendant.Rows[row].Cells[colId.Index].Value);
        }
        private void dgvAttendant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checking collumn clicked to define if is alteration or deleting routine
            if (e.ColumnIndex == dgvAttendant.Columns["colEdit"].Index)
                if (MessageBox.Show("Deseja realmente editar esse aluno?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    new AttendantSettings(attendant.Id).ShowDialog(); // if is alteration routine

                else if (e.ColumnIndex == dgvAttendant.Columns["colDelete"].Index)
                    if (MessageBox.Show("Deseja realmente excluir esse aluno?", "CUIDADO - EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        service.AttendantDelete(attendant.Id); // if is deleting routine

            LoadAllAttendantData();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Cleaning fields
            cmbClass.SelectedIndex = 0;
            dtpInitial.Checked = false;
            dtpFinal.Checked = false;
            txtTitle.Text = string.Empty;
        }
        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            // Date Validation
            if (dtpInitial.Value > dtpFinal.Value)
            {
                MessageBox.Show("Data final não pode ser menor que a data inicial", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpInitial.Value = dtpFinal.Value = DateTime.Today;
            }
        }
        #endregion

        #region ..:: Other Methods ::.. 
        private void FillClassCombo()
        {
            service.FillClassCombo(ref cmbClass);
        }
        private void LoadAllAttendantData()
        {
            bool IsDateActivated;
            if (dtpInitial.Checked == true)
                IsDateActivated = true;
            else IsDateActivated = false;
            // Values attribution to properties and searching values on database to fill Datagrid
            ValueAttribution();
            dgvAttendant.DataSource = null;
            dgvAttendant.AutoGenerateColumns = false;
            dgvAttendant.DataSource = service.LoadAllAttendantData(attendant, IsDateActivated);
        }
        private void ValueAttribution()
        {
            attendant.ClassId = Convert.ToInt32(cmbClass.SelectedValue);
            attendant.DateInitial = dtpInitial.Value;
            attendant.DateFinal = dtpFinal.Value;
            attendant.Title = txtTitle.Text;
        }
        #endregion
    }
}
