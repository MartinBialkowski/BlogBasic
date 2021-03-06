﻿using System.ComponentModel.DataAnnotations;

namespace BlogPost.Core.Entities
{
    public class Student : IEntityBase
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public Course Course { get; set; }
    }
}
