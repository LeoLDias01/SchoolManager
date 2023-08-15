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
    public partial class ClassSettings : Form
    {
        Service service = new Service();
        Classroom classroom = new Classroom();

        public int idClass;
        public ClassSettings(int id = 0)
        {
            InitializeComponent();
            idClass = id; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClass.Text = string.Empty;
            cmbTerm.SelectedIndex = 0;
        }

        private void ClassSettings_Load(object sender, EventArgs e)
        {
            FillTermCombo();
            if (idClass > 0)
                LoadClassData();
        }
        private void FillTermCombo()
        {
            service.FillTermCombo(ref cmbTerm);
        }
        private bool FieldValidation() 
        {
            if (txtClass.Text.Length > 1 && cmbTerm.SelectedIndex > 0) 
                return true;
            else 
                return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FieldValidation())
            {
                ValueAttribution();

                if (idClass > 0)
                    service.AlterClass(classroom);
                else
                    service.CreateClass(classroom);

                this.Close();
            }
            else
                MessageBox.Show("Campos Inválidos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ValueAttribution()
        {
            classroom.Id = idClass;
            classroom.Name = txtClass.Text;
            classroom.Term = Convert.ToInt32(cmbTerm.SelectedValue);
        }
        private void LoadClassData()
        {
            List<Classroom> classroom = service.LoadClassData(idClass);
            foreach (var item in classroom)
            { 
                txtClass.Text = item.Name;
                cmbTerm.SelectedValue = item.Term;
            }
        }
    }
}
