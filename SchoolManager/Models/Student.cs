using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Models
{
    public struct Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
        public DateTime Birth  { get; set; }
        public int ClassId { get; set; }
        public string ClassDescription { get; set; }
        public string Observation { get; set; }
        public bool? IsHere { get; set; }
    }
}
