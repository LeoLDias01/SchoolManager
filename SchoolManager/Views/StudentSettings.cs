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
    public partial class StudentSettings : Form
    {
        Service service = new Service();
        Student student = new Student();

        public StudentSettings(int id = 0)
        {
            InitializeComponent();
            student.Id = id;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtObservation.Text = string.Empty; 
            cmbClass.SelectedIndex = 0;
            dtpBirth.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FieldValidation())
            {
                ValueAttribution();

                if (student.Id > 0)
                    service.StudentAlter(student);
                else
                    service.StudentCreate(student);

                this.Close();
            }
            else
                MessageBox.Show("Campos Inválidos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void StudentSettings_Load(object sender, EventArgs e)
        {
            FillClassCombo();
            if (student.Id > 0)
                LoadStudentData();
        }
        private void FillClassCombo()
        {
            service.FillClassCombo(ref cmbClass);
        }
        private void LoadStudentData()
        {
            List<Student> classroom = service.LoadStudentData(student.Id);
            foreach (var item in classroom)
            {
                txtName.Text = item.Name;
                txtCPF.Text = item.CPF;
                txtAge.Text = item.Age.ToString();
                if (item.Birth != null)
                {
                    dtpBirth.Checked = true;
                    dtpBirth.Value = item.Birth;
                }
                txtObservation.Text = item.Observation;
                cmbClass.SelectedValue = item.ClassId;
            }
        }
        private bool FieldValidation()
        {
            if (txtName.Text.Length > 1 && txtCPF.Text.Length > 1 && cmbClass.SelectedIndex > 0 && dtpBirth.Checked == true)
                return true;
            else
                return false;
        }
        private void ValueAttribution()
        {
            student.Name = txtName.Text;
            student.CPF = txtCPF.Text;
            student.Age = Convert.ToInt32(txtAge.Text);
            student.Observation = txtObservation.Text;
            student.Birth = dtpBirth.Value;
            student.ClassId = Convert.ToInt32(cmbClass.SelectedValue);
        }
    }
}
