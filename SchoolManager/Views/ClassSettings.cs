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
        #region ..:: Instances and Variables ::..
        public int idClass;

        public Service service = new Service();
        public Classroom classroom = new Classroom();
        #endregion

        #region ..:: Constructor ::..
        public ClassSettings(int id = 0)
        {
            InitializeComponent();
            // Class Id Attribution
            idClass = id; 
        }
        #endregion

        #region ..:: Events ::..
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Cleaning Fields
            txtClass.Text = string.Empty;
            cmbTerm.SelectedIndex = 0;
        }
        private void ClassSettings_Load(object sender, EventArgs e)
        {
            // Fill ComboBox
            FillTermCombo();
            if (idClass > 0)
                LoadClassData();// Search classroom data and fill fields 
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (FieldValidation())
            {
                // Fields Value Attribution
                ValueAttribution();

                if (idClass > 0)
                    service.AlterClass(classroom); // Alteration 
                else
                    service.CreateClass(classroom); // Creation

                this.Close();
            }
            else
                MessageBox.Show("Campos Inválidos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region ..:: Other Methods ::..
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
        #endregion
    }
}
