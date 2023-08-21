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
        Service service = new Service();
        AttendantData attendant = new AttendantData();
        public AttendantSettings()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = string.Empty;
            txtObservation.Text = string.Empty;
            dtpDateOfAttendant.Checked = false;
            cmbClass.SelectedIndex = 0;
            dgvIsHere.DataSource = null;
        }
        private void FillClassCombo()
        {
            service.FillClassCombo(ref cmbClass);
        }

        private void AttendantSettings_Load(object sender, EventArgs e)
        {
            FillClassCombo();
            if (attendant.Id > 0)
                LoadStudentData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FieldValidation())
            {
                ValueAttribution();

                if (attendant.Id > 0)
                    service.AttendantAlter(attendant);
                else
                    attendant.Id = service.AttendantCreate(attendant);

                cmbClass.Enabled = false;
                GetStudents();
            }
            else
                MessageBox.Show("Campos Inválidos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
