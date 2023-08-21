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

        #region ..:: Login ::..
        public bool LogIn(string user, string password)
        {
            return database.Login(user, password);
        }
        #endregion

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

        #region ..:: Student ::..
        public void FillClassCombo(ref ComboBox combo)
        {
            try
            {
                List<GenericClass> tipoSegmento = database.FillClassCombo();
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
        public void StudentCreate(Student student)
        {
            try
            {
                MessageBox.Show($"{database.StudentCreate(student)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'StudentCreate'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void StudentAlter(Student student)
        {
            try
            {
                MessageBox.Show($"{database.StudentAlter(student)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'StudentAlter'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void StudentDelete(int studentId)
        {
            try
            {
                MessageBox.Show($"{database.StudentDelete(studentId)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'StudentDelete'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Student> LoadStudentData(int studentId)
        {
            try
            {
                return database.LoadStudentData(studentId);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'LoadStudentData'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Student> LoadAllStudentsData(Student student)
        {
            try
            {
                return database.LoadAllStudentsData(student);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'LoadAllStudentsData'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region ..:: Attendant ::..

        public int AttendantCreate(AttendantData attendant)
        {
            try
            {
                int id = database.AttendantCreate(attendant);
                if(id > 0)
                    MessageBox.Show($"Chamada Criada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return id; 
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'AttendantCreate'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public void AttendantAlter(AttendantData attendant)
        {
            try
            {
                MessageBox.Show($"{database.AttendantAlter(attendant)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'AttendantAlter'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AttendantDelete(int attendantId)
        {
            try
            {
                MessageBox.Show($"{database.AttendantDelete(attendantId)}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'AttendantDelete'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<AttendantData> LoadAttendantData(int attendantId)
        {
            try
            {
                return database.LoadAttendantData(attendantId);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'LoadAttendantData'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        /* public List<AttendantData> LoadAllAttendantsData(AttendantData attendant)
         {
             try
             {
                 return database.LoadAllAttendantsData(attendant);
             }
             catch
             {
                 MessageBox.Show("Houve um Erro no Método 'LoadAllAttendantsData'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return null;
             }
        }*/
        public List<AttendantData> GetStudents(int attendantId)
        {
            try
            {
                return database.GetStudents(attendantId);
            }
            catch
            {
                MessageBox.Show("Houve um Erro no Método 'GetStudents'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion
    }
}
