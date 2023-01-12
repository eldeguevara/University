﻿using System.ComponentModel.DataAnnotations;
namespace UNIVERSITYAPI.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }
        
        public ICollection<Course> Categories { get; set; } = new List<Course>();

    }
}
