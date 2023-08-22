using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Models
{
    /// <summary>
    /// Attendant Data
    /// </summary>
    public struct AttendantData
    {
        [Description("Attendant Id")]
        public int Id { get; set; }

        [Description("Attendant Name")]
        public string Title { get; set; }

        [Description("Date when attendant is realized")]
        public DateTime DateOfAttendant { get; set; }

        [Description("Classroom Id")]
        public int ClassId { get; set; }

        [Description("Classroom Name")]
        public string ClassDescription {get; set; }

        [Description("Observations")]
        public string Observation { get; set; }

        [Description("Id of organizer table")]
        public int IdAttendantStudent { get; set; }

        [Description("Student Id")]
        public int IdStudent { get; set;}

        [Description("Student Name")]
        public string Student { get; set; }

        [Description("If students are in the school")]
        public bool IsHere { get; set; }

        [Description("Initial Date to search filter")]
        public DateTime DateInitial { get; set; }

        [Description("Final Date to search filter")]
        public DateTime DateFinal { get; set; }
    }
}
