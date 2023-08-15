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

namespace SchoolManager.Controllers
{
    public class Database
    {
        public string sqlConnection = "Data Source=DESKTOP-D99O6K1\\SQLEXPRESS;Initial Catalog=SCHOOL_MANAGER;Integrated Security = SSPI";
             
        public bool Login(string user, string password)
        {
            using (var conn = new SqlConnection(sqlConnection))
            {
                return conn.QuerySingle<bool>($@"PRC_USER_DATA_CHECK @USER, @PASSWORD",
                                            param: new { USER = user, PASSWORD = password });
            }
        }
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
    }
}
