﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.BLL.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public IList<SubjectGroup> SubjectGroups { get; set; }

        public Teacher Teacher { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        public IList<Grade> Grades { get; set; }
    }
}
