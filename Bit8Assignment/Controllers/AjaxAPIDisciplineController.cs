using Bit8Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bit8Assignment.Controllers
{
    public class AjaxAPIDisciplineController : ApiController
    {
        // GET api/<controller>
        [Route("api/AjaxAPIDiscipline/InsertDiscipline")]
        [HttpPost]
        public Discipline InsertDiscipline(Discipline _discipline)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                entities.Disciplines.Add(_discipline);
                entities.SaveChanges();
            }

            return _discipline;
        }

        [Route("api/AjaxAPIDiscipline/UpdateDiscipline")]
        [HttpPost]
        public bool UpdateDiscipliner(Discipline _discipline)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                Discipline updatedDiscipline = (from c in entities.Disciplines
                                            where c.ID == _discipline.ID
                                            select c).FirstOrDefault();
                updatedDiscipline.DisciplineName = _discipline.DisciplineName;
                updatedDiscipline.ProfesorName = _discipline.ProfesorName;
                entities.SaveChanges();
            }

            return true;
        }

        [Route("api/AjaxAPIDiscipline/DeleteDiscipline")]
        [HttpPost]
        public void DeleteDiscipline(Discipline _discipline)
        {
            using (Bit8Entities entities = new Bit8Entities())
            {
                Discipline discipline = (from c in entities.Disciplines
                                         where c.ID == _discipline.ID
                                     select c).FirstOrDefault();
                entities.Disciplines.Remove(_discipline);
                entities.SaveChanges();
            }
        }
    }
}