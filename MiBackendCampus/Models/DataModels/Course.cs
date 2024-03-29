﻿using System.ComponentModel.DataAnnotations;

namespace MiBackendCampus.Models.DataModels
{
    public enum Level 
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3,
        Expert = 4
    }

    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string LongDescription { get; set; } = string.Empty;

        public Level Level { get; set; } = Level.Beginner;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();

        [Required]
        public Chapter Chapter { get; set; } = new Chapter();
    }
}
