using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Models
{
    public struct AttendantData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfAttendant { get; set; }
        public int ClassId { get; set; }
        public string ClassDescription{ get; set; }
        public string Observation { get; set; }
        public int IdAttendantStudent { get; set; }
        public int IdStudent { get; set;}
        public string Student { get; set; }
        public bool IsHere { get; set; }
    }
}
