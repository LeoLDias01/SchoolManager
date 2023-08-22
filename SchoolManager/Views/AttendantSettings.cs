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
using System.Xml.Linq;

namespace SchoolManager.Views
{
    public partial class AttendantSettings : Form
    {
        #region ..:: Instances and Variables ::..
        Service service = new Service();
        AttendantData attendant = new AttendantData();
        #endregion

        #region ..:: Constructor ..::
        public AttendantSettings(int id = 0)
        {
            InitializeComponent();
            attendant.Id = id;
        }
        #endregion

        #region ..:: Events ::..
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Cleaning fields
            txtTitle.Text = string.Empty;
            txtObservation.Text = string.Empty;
            dtpDateOfAttendant.Checked = false;
            cmbClass.SelectedIndex = 0;
            dgvIsHere.DataSource = null;
            attendant = new AttendantData();
            attendant.Id = 0;

        }
        private void AttendantSettings_Load(object sender, EventArgs e)
        {
            // Fill combo
            FillClassCombo();
            if (attendant.Id > 0)
                LoadStudentData(); // Get Data
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Fields value validation
            if (FieldValidation())
            {
                // Values attribution
                ValueAttribution();

                if (attendant.Id > 0)
                    service.AttendantAlter(attendant); // Alteration Routine
                else
                    attendant.Id = service.AttendantCreate(attendant); // Creation Routine

                cmbClass.Enabled = false;
                // fill datagrid
                GetStudents();
            }
            else
                MessageBox.Show("Campos Inválidos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void dgvIsHere_SelectionChanged(object sender, EventArgs e)
        {
            // Searching Id in selected line
            DataGridViewRow ActualLine = dgvIsHere.CurrentRow;
            int row = ActualLine.Index;
            attendant.IdAttendantStudent = Convert.ToInt32(dgvIsHere.Rows[row].Cells[colId.Index].Value);
            attendant.IdStudent = Convert.ToInt32(dgvIsHere.Rows[row].Cells[colIdStudent.Index].Value);
        }
        private void dgvIsHere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvIsHere.Columns["colMark"].Index)
            {
                // Saving Values
                service.AttendantCheck(attendant);
            }
            GetStudents();
        }
        #endregion

        #region ..:: Other Methods ::..
        private void FillClassCombo()
        {
            service.FillClassCombo(ref cmbClass);
        }
        private bool FieldValidation()
        {
            if (txtTitle.Text.Length > 1 && cmbClass.SelectedIndex > 0 && dtpDateOfAttendant.Checked == true)
                return true;
            else
                return false;
        }
        private void ValueAttribution()
        {
            attendant.Title = txtTitle.Text;
            attendant.DateOfAttendant = dtpDateOfAttendant.Value;
            attendant.ClassId = Convert.ToInt32(cmbClass.SelectedValue);
            attendant.Observation = txtObservation.Text;
        }
        private void LoadStudentData()
        {
            cmbClass.Enabled = false;
            List<AttendantData> classroom = service.LoadAttendantData(attendant.Id);
            foreach (var item in classroom)
            {
                txtTitle.Text = item.Title;
                if (item.DateOfAttendant != null)
                {
                    dtpDateOfAttendant.Checked = true;
                    dtpDateOfAttendant.Value = item.DateOfAttendant;
                }
                cmbClass.SelectedValue = item.ClassId;
                txtObservation.Text = item.Observation;
            }
            GetStudents();
        }
        private void GetStudents()
        {
            dgvIsHere.DataSource = null;
            dgvIsHere.AutoGenerateColumns = false;
            dgvIsHere.DataSource = service.GetStudents(attendant.Id);
        }
        #endregion 
    }
}
