using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Models
{
    public struct Classroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Term { get; set; }
        public string TermDescription { get; set; }
    }
}
