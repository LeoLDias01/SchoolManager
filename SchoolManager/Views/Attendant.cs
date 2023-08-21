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
    public partial class Attendant : Workspace
    {
        Service service = new Service();
        public Attendant()
        {
            InitializeComponent();
        }

        private void Attendant_Load(object sender, EventArgs e)
        {
            FillClassCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AttendantSettings().ShowDialog();
        }
        private void FillClassCombo()
        {
            service.FillClassCombo(ref cmbClass);
        }
    }
}
