using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace SchoolManager.Views
{
    public partial class Workspace : Form
    {
        #region ..:: Constructor ::..
        public Workspace()
        {
            InitializeComponent();
        }
        #endregion

        #region ..:: Events ::..
        private void tsbExit_Click(object sender, EventArgs e)
        {
           // Closing Application
           Application.Exit();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            // Hide actual form and call a new form  
            this.Hide(); 
            new Class().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Hide actual form and call a new form  
            this.Hide();
            new Workspace().Show();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            // Hide actual form and call a new form  
            this.Hide();
            new Students().ShowDialog(); 
        }

        private void btnAttendant_Click(object sender, EventArgs e)
        {
            // Hide actual form and call a new form  
            this.Hide();
            new Attendant().ShowDialog();
        }
        #endregion
    }
}
