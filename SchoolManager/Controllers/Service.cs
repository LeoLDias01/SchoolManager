using SchoolManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManager.Controllers
{
    public class Service
    {
        Database database = new Database();
        public bool LogIn(string user, string password)
        {
            return database.Login(user, password);
        }

        #region ..:: Class ::..
        public void FillTermCombo(ref ComboBox combo)
        {
            try
            {
                List<GenericClass> tipoSegmento = database.FillTermCombo();
                tipoSegmento.Insert(0, new GenericClass { Description = "<Selecione>", Id = 0 });
                combo.DataSource = tipoSegmento;
                combo.DisplayMember = "Description";
                combo.ValueMember = "Id";
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'FillTermCombo'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CreateClass(Classroom classroom)
        {
            try
            {
                MessageBox.Show($"{database.CreateClass(classroom)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Houve um Erro no Método 'CreateClass'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AlterClass(Classroom classroom)
        {
            try
            {
                MessageBox.Show($"{database.AlterClass(classroom)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'CreateClass'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteClass(int classId)
        {
            try
            {
                MessageBox.Show($"{database.DeleteClass(classId)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'DeleteClass'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Classroom> LoadClassData(int idClass)
        {
            try
            {
                return database.LoadClassData(idClass);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'LoadClassData'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Classroom> LoadAllClassData(Classroom classroom)
        {
            try
            {
                return database.LoadAllClassData(classroom);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'LoadAllClassData'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion
    }
}
