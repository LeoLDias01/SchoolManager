using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Models
{
    /// <summary>
    /// Generic class to be used in multiple methods
    /// </summary>
    public class GenericClass
    {
        [Description("Id - used to fill ComboBox value")]
        public int Id { get; set; }

        [Description("Description - used to fill ComboBox Text")]
        public string Description { get; set; }
    }
}
