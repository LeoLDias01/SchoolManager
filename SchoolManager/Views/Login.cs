using SchoolManager.Controllers;
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
    public partial class Login : Form
    {
        #region ..:: Instances And Variables ::..
        Service service = new Service();
        #endregion

        #region ..:: Constructor ::..
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::.. 
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Checking if fields are correct
            if (FieldsValidation()) LogIn();
            else MessageBox.Show("Campos Inválidos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region ..:: Other Methods ::..

        /// <summary>
        /// Checking Fields Method
        /// </summary>
        /// <returns>Return validation result</returns>
        private bool FieldsValidation()
        {
            if (txtUser.TextLength > 0 && txtPassword.TextLength > 0) return true;
            else return false;
        }

        /// <summary>
        /// Go to home page if user is correct
        /// </summary>
        private void LogIn() 
        {
            // Verifying User
            if (service.LogIn(txtUser.Text.Trim(), txtPassword.Text.Trim()) == true)
            {
                this.Hide();
                new Workspace().ShowDialog();
            }
            else
                MessageBox.Show("Email ou senha incorretos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
