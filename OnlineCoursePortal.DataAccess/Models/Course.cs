﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoursePortal.DataAccess.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Course Name is required.")]
        [StringLength(20, ErrorMessage = "Course Name cannot exceed 20 characters.")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Course Description is required.")]
        [StringLength(500, ErrorMessage = "Course Description cannot exceed 500 characters.")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "Start Date is required.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Available Seats is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Available Seats must be a non-negative number.")]
        public int AvailableSeats { get; set; }
    }
}
