using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Models
{
    /// <summary>
    /// Student Data
    /// </summary>
    public struct Student
    {
        [Description("Student id")]
        public int Id { get; set; }

        [Description("Student Name")]
        public string Name { get; set; }

        [Description("Student SSN")]
        public string CPF { get; set; }

        [Description("Student Age")]
        public int Age { get; set; }

        [Description("Student date of birth")]
        public DateTime Birth  { get; set; }

        [Description("Classroom Id")]
        public int ClassId { get; set; }

        [Description("Classroom Name")]
        public string ClassDescription { get; set; }

        [Description("General observations")]
        public string Observation { get; set; }
    }
}
