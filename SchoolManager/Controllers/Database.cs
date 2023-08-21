using Dapper;
using SchoolManager.Models;
using SchoolManager.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManager.Controllers
{
    public class Database
    {
        public string sqlConnection = "Data Source=DESKTOP-D99O6K1\\SQLEXPRESS;Initial Catalog=SCHOOL_MANAGER;Integrated Security = SSPI";

        #region ..:: Login ::.    
        public bool Login(string user, string password)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<bool>($@"PRC_USER_DATA_CHECK @USER, @PASSWORD",
                                            param: new { USER = user, PASSWORD = password });
            }
        }
        #endregion

        #region ..:: Class ::..
        public List<GenericClass> FillTermCombo()
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.Query($@"SELECT   ID_TERM AS ID
                                            , DESCRIPTION_TERM AS [DESCRIPTION] 
                                     FROM TERM 
                                     WHERE ACTIVE = 1")
                .Select(x => new GenericClass
                {
                    Id = x.ID,
                    Description = x.DESCRIPTION
                }).ToList();
            }
        }
        public string CreateClass(Classroom classroom)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"PRC_CLASS_CREATE @CLASSNAME, @TERM",
                param: new { CLASSNAME = classroom.Name, TERM = classroom.Term });
            }
        }
        public string AlterClass(Classroom classroom)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"UPDATE CLASS 
                                                   SET CLASS = @CLASSNAME, ID_TERM = @TERM
                                                   WHERE ID_CLASS = @ID AND ACTIVE = 1
                                                   
                                                   SELECT 'Alterado com Sucesso!'   ",
                param: new { ID = classroom.Id, CLASSNAME = classroom.Name, TERM = classroom.Term });
            }
        }
        public string DeleteClass(int classId)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"UPDATE CLASS 
                                                   SET ACTIVE = 0
                                                   WHERE ID_CLASS = @ID AND ACTIVE = 1
                                                   
                                                   SELECT 'Excluído com Sucesso!'   ",
                param: new { ID = classId});
            }
        }
        public List<Classroom> LoadClassData(int idClass)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.Query(@"SELECT CLASS, ID_TERM
                                    FROM CLASS WITH(NOLOCK)
                                    WHERE ID_CLASS = @ID",
                param: new { ID = idClass})
                    .Select(x => new Classroom
                    {
                        Name = x.CLASS,
                        Term = x.ID_TERM
                    }).ToList();
            }
        }
        public List<Classroom> LoadAllClassData(Classroom classroom)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                string sql = $@"SELECT CLS.ID_CLASS, CLS.CLASS, TRM.DESCRIPTION_TERM AS TERM
                                FROM CLASS          CLS WITH(NOLOCK)
                                INNER JOIN TERM     TRM WITH(NOLOCK) ON TRM.ID_TERM = CLS.ID_TERM
                                WHERE CLS.ACTIVE = 1 ";
                if (classroom.Name.Length > 1)
                    sql += $"AND CLS.CLASS = '{classroom.Name}'";
                if (classroom.Term > 1)
                    sql += $"AND CLS.ID_TERM = {classroom.Term}";

                sql += "ORDER BY CLS.CLASS ASC";


                return conn.Query(sql)
                    .Select(x => new Classroom
                    {
                        Id = x.ID_CLASS,
                        Name = x.CLASS,
                        TermDescription = x.TERM
                    }).ToList();
            }
        }

        #endregion

        #region ..:: Student ::..
        public List<GenericClass> FillClassCombo()
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.Query($@"SELECT   ID_CLASS AS ID
                                            , CLASS AS [DESCRIPTION] 
                                     FROM CLASS 
                                     WHERE ACTIVE = 1")
                .Select(x => new GenericClass
                {
                    Id = x.ID,
                    Description = x.DESCRIPTION
                }).ToList();
            }
        }
        public string StudentCreate(Student student)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"PRC_STUDENT_CREATE @NAME_STUDENT, @CPF, @AGE, @BIRTH, @ID_CLASS, @OBSERVATIONS",
                param: new { NAME_STUDENT = student.Name, CPF = student.CPF, AGE = student.Age, BIRTH = student.Birth, ID_CLASS = student.ClassId, OBSERVATIONS = student.Observation});
            }
        }
        public string StudentAlter(Student student)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"UPDATE STUDENT 
                                                   SET NAME_STUDENT = @NAME_STUDENT, CPF = @CPF, AGE = @AGE, BIRTH = @BIRTH, ID_CLASS = @ID_CLASS, OBSERVATIONS = @OBSERVATIONS
                                                   WHERE ID_STUDENT = @ID AND ACTIVE = 1
                                                   
                                                   SELECT 'Alterado com Sucesso!'   ",
                param: new { ID = student.Id, NAME_STUDENT = student.Name, CPF = student.CPF, AGE = student.Age, BIRTH = student.Birth, ID_CLASS = student.ClassId, OBSERVATIONS = student.Observation });
            }
        }
        public string StudentDelete(int studentId)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"UPDATE STUDENT 
                                                   SET ACTIVE = 0
                                                   WHERE ID_STUDENT = @ID AND ACTIVE = 1
                                                   
                                                   SELECT 'Excluído com Sucesso!'   ",
                param: new { ID = studentId });
            }
        }
        public List<Student> LoadStudentData(int StudentId)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.Query(@"SELECT NAME_STUDENT, CPF, AGE, BIRTH, ID_CLASS, OBSERVATIONS
                                    FROM STUDENT WITH(NOLOCK)
                                    WHERE ID_STUDENT = @ID",
                param: new { ID = StudentId })
                    .Select(x => new Student
                    {
                        Name = x.NAME_STUDENT,
                        CPF = x.CPF,
                        Age = x.AGE,
                        Birth = x.BIRTH,
                        ClassId = x.ID_CLASS,
                        Observation = x.OBSERVATIONS,
                    }).ToList();
            }
        }
        public List<Student> LoadAllStudentsData(Student student)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                string sql = $@"SELECT STD.ID_STUDENT, STD.NAME_STUDENT, STD.CPF, STD.AGE, STD.BIRTH, CLS.CLASS, STD.OBSERVATIONS
                                FROM STUDENT		STD WITH(NOLOCK)
                                INNER JOIN CLASS	CLS WITH(NOLOCK) ON CLS.ID_CLASS = STD.ID_CLASS
                                WHERE STD.ACTIVE = 1";
                if (student.Name.Length > 1)
                    sql += $"AND STD.NAME_STUDENT = '{student.Name}'";
                if (student.CPF.Length > 1)
                    sql += $"AND STD.CPF = '{student.CPF}'";
                if (student.ClassId > 1)
                    sql += $"AND CLS.ID_CLASS = {student.ClassId}";

                sql += "ORDER BY STD.NAME_STUDENT ASC";


                return conn.Query(sql)
                    .Select(x => new Student
                    {
                        Id = x.ID_STUDENT,
                        Name = x.NAME_STUDENT,
                        CPF = x.CPF,
                        Age = x.AGE,
                        Birth = x.BIRTH,
                        ClassDescription = x.CLASS,
                        Observation = x.OBSERVATIONS,
                    }).ToList();
            }
        }
        #endregion

        #region ..:: Attendant ::..

        public int AttendantCreate(AttendantData attendant)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<int>($@"PRC_ATTENDANT_CREATE @TITLE, @DATE_OF_ATTENDANT, @ID_CLASS, @OBSERVATIONS",
                param: new { TITLE = attendant.Title, DATE_OF_ATTENDANT = attendant.DateOfAttendant, ID_CLASS = attendant.ClassId, OBSERVATIONS = attendant.Observation});
            }
        }
        public string AttendantAlter(AttendantData attendant)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"UPDATE STUDENT 
                                                   SET TITLE = @TITLE, DATE_OF_ATTENDANT = @DATE_OF_ATTENDANT, ID_CLASS = @ID_CLASS, OBSERVATIONS = @OBSERVATIONS
                                                   WHERE ID_ATTENDANT = @ID AND ACTIVE = 1
                                                   
                                                   SELECT 'Alterado com Sucesso!'   ",
                param: new { ID = attendant.Id, TITLE = attendant.Title, DATE_OF_ATTENDANT = attendant.DateOfAttendant,ID_CLASS = attendant.ClassId, OBSERVATIONS = attendant.Observation });
            }
        }
        public string AttendantDelete(int studentId)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<string>($@"UPDATE STUDENT 
                                                   SET ACTIVE = 0
                                                   WHERE ID_STUDENT = @ID AND ACTIVE = 1
                                                   
                                                   SELECT 'Excluído com Sucesso!'   ",
                param: new { ID = studentId });
            }
        }
        public List<AttendantData> LoadAttendantData(int AttendantId)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.Query(@"SELECT TITLE, DATE_OF_ATTENDANT, ID_CLASS, OBSERVATIONS 
                                    FROM ATTENDANT
                                    WHERE ID_ATTENDANT = @ID",
                param: new { ID = AttendantId })
                    .Select(x => new AttendantData
                    {
                        Title = x.TITLE,
                        DateOfAttendant = x.DATE_OF_ATTENDANT,
                        ClassId = x.ID_CLASS,
                        Observation = x.OBSERVATIONS,
                    }).ToList();
            }
        }
        /*public List<AttendantData> LoadAllAttendantsData(AttendantData attendantt)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                string sql = $@"SELECT STD.ID_STUDENT, STD.NAME_STUDENT, STD.CPF, STD.AGE, STD.BIRTH, CLS.CLASS, STD.OBSERVATIONS
                                FROM STUDENT		STD WITH(NOLOCK)
                                INNER JOIN CLASS	CLS WITH(NOLOCK) ON CLS.ID_CLASS = STD.ID_CLASS
                                WHERE STD.ACTIVE = 1";
                if (student.Name.Length > 1)
                    sql += $"AND STD.NAME_STUDENT = '{student.Name}'";
                if (student.CPF.Length > 1)
                    sql += $"AND STD.CPF = '{student.CPF}'";
                if (student.ClassId > 1)
                    sql += $"AND CLS.ID_CLASS = {student.ClassId}";

                sql += "ORDER BY STD.NAME_STUDENT ASC";


                return conn.Query(sql)
                    .Select(x => new AttendantData
                    {
                        Id = x.ID_STUDENT,
                        Name = x.NAME_STUDENT,
                        CPF = x.CPF,
                        Age = x.AGE,
                        Birth = x.BIRTH,
                        ClassDescription = x.CLASS,
                        Observation = x.OBSERVATIONS,
                    }).ToList();
            }
        }*/
        public List<AttendantData> GetStudents(int AttendantId)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.Query(@"SELECT ATS.ID_ATTENDANT_STUDENT, STD.ID_STUDENT, STD.NAME_STUDENT, ATS.IS_HERE
                                    FROM ATTENDANT_STUDENT  ATS WITH(NOLOCK)
                                    LEFT JOIN ATTENDANT     ATD WITH(NOLOCK) ON ATD.ID_ATTENDANT    = ATS.ID_ATTENDANT
                                    LEFT JOIN STUDENT	    STD WITH(NOLOCK) ON STD.ID_STUDENT      = ATS.ID_STUDENT
                                    WHERE ATS.ID_ATTENDANT = @ID",
                param: new { ID = AttendantId })
                    .Select(x => new AttendantData
                    {
                        IdAttendantStudent = x.ID_ATTENDANT_STUDENT,
                        IdStudent = x.ID_STUDENT,
                        Student = x.NAME_STUDENT,
                        IsHere = x.IS_HERE
                    }).ToList();
            }
        }
        #endregion
    }
}
