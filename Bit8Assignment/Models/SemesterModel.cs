using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bit8Assignment.Models
{
    public class SemesterModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class SemesterListModel
    {
        public Semester Semeter { get; set; }
    }
}