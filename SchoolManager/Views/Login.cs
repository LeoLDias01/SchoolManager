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
        Service service = new Service();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (FieldsValidation()) LogIn();
            else MessageBox.Show("Campos Inválidos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool FieldsValidation()
        {
            if (txtUser.TextLength > 0 && txtPassword.TextLength > 0) return true;
            else return false;
        }
        private void LogIn() 
        {
            if (service.LogIn(txtUser.Text.Trim(), txtPassword.Text.Trim()) == true)
            {
                this.Hide();
                new Workspace().ShowDialog();
            }
            else
                MessageBox.Show("Email ou senha incorretos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
