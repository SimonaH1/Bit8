using Bit8Assignment.Models;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Mvc;

namespace Bit8Assignment
{
    public partial class Semester 
    {
        public SelectList DisciplinesSelectList = new SelectList(new Bit8Entities().Disciplines, "ID", "DisciplineName");
        public int DisciplineID { get; set; }

        public List<SemesterDiscipline> SemesterDisciplineList => new Bit8Entities().SemesterDisciplines.Where(x => x.SemesterID == Id).ToList();

    }

    public class Data 
    {
        public Data() { }
        public List<StudentDisciplinesWithoutScores_Result> List => new Bit8Entities().StudentDisciplinesWithoutScores().ToList<StudentDisciplinesWithoutScores_Result>();
    }
}