﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnglisCenter.Accessor.Entities
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string TimeStudy { get; set; } // ? month

        public string Description { get; set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}