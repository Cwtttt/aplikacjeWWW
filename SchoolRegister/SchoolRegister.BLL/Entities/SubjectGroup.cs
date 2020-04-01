using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.BLL.Entities
{
    public class SubjectGroup
    {
        public Subject Subject { get; set; }

        public int SubjectId { get; set; }

        public Group Group { get; set; }

        public int GroupId { get; set; }

    }
}
