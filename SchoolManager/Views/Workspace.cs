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
        public Workspace()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Workspace_Load(object sender, EventArgs e)
        {
        
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Class().Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Workspace().Show();
        }
    }
}
