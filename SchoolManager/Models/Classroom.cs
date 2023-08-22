using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Models
{
    /// <summary>
    /// Classroom Data
    /// </summary>
    public struct Classroom
    {
        [Description("Classroom Id")]
        public int Id { get; set; }

        [Description("Classroom Name")]
        public string Name { get; set; }

        [Description("Classroom Term Id")]
        public int Term { get; set; }

        [Description("Classroom Term (Morning, Afternoon, Night)")]
        public string TermDescription { get; set; }
    }
}
