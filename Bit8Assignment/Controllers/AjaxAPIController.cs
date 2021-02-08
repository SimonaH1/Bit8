using System;
using System.Linq;
using System.Web.Http;
using Bit8Assignment;
using Bit8Assignment.Models;

namespace Bit8Assignment.Controllers
{
    public class AjaxAPIController : ApiController
    {
        [Route("api/AjaxAPI/InsertSemester")]
        [HttpPost]
        public Semester InsertSemester(Semester _semester)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                entities.Semesters.Add(_semester);
                entities.SaveChanges();
            }

            return _semester;
        }

        [Route("api/AjaxAPI/UpdateSemester")]
        [HttpPost]
        public bool UpdateSemester(Semester _semester)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                Semester updatedSemester = (from c in entities.Semesters
                                            where c.Id == _semester.Id
                                            select c).FirstOrDefault();
                updatedSemester.Name = _semester.Name;
                updatedSemester.StartDate = _semester.StartDate;
                updatedSemester.EndDate = _semester.EndDate;
                entities.SaveChanges();
            }

            return true;
        }

        [Route("api/AjaxAPI/DeleteSemester")]
        [HttpPost]
        public void DeleteSemester(Semester _semester)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                Semester semester = (from c in entities.Semesters
                                     where c.Id == _semester.Id
                                     select c).FirstOrDefault();
                entities.Semesters.Remove(semester);
                entities.SaveChanges();
            }
        }

        [Route("api/AjaxAPI/InsertSemesterDiscipline")]
        [HttpPost]
        public Semester InsertSemesterDiscipline(SemesterDiscipline _semesterDiscipline)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                entities.SemesterDisciplines.Add(_semesterDiscipline);
                entities.SaveChanges();
            }
            return new Semester();
        }

        [Route("api/AjaxAPI/DeleteSemesterDiscipline")]
        [HttpPost]
        public Semester DeleteSemesterDiscipline(SemesterDiscipline _semesterDiscipline)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                SemesterDiscipline semesterDiscipline = (from c in entities.SemesterDisciplines
                                     where c.SemesterID == _semesterDiscipline.SemesterID && 
                                      c.DisciplineID == _semesterDiscipline.DisciplineID
                                     select c).FirstOrDefault();
                entities.SemesterDisciplines.Remove(semesterDiscipline);
                entities.SaveChanges();
            }
            return new Semester();
        }
    }
}
