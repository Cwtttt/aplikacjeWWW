using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.BLL.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Student> Students { get; set; }

        public IList<SubjectGroup> SubjectGroups { get; set; }



    }
}
