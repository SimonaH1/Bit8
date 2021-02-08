using Bit8Assignment.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Bit8Assignment
{
    public partial class Semester 
    {
        public SelectList DisciplinesSelectList = new SelectList(new Bit8Entities().Disciplines, "ID", "DisciplineName");
        public int DisciplineID { get; set; }

        public List<SemesterDiscipline> SemesterDisciplineList => new Bit8Entities().SemesterDisciplines.Where(x => x.SemesterID == Id).ToList();

        public List<StudentDisciplinesWithoutScores_Result> List => new Bit8Entities().StudentDisciplinesWithoutScores().ToList();
    }
}