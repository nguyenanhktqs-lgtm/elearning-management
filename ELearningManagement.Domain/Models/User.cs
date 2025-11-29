using System;
using System.Collections.Generic;

namespace ELearningManagement.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; } // Unique identifier for the user
        public string Username { get; set; } // Username for the user account
        public string Email { get; set; } // Email address for the user
        public string PasswordHash { get; set; } // Hashed password for security
        public string FullName { get; set; } // Full name of the user
        public string Role { get; set; } // Role of the user (e.g., Admin, Student, Instructor)
        public DateTime CreatedDate { get; set; } // Date and time when the user was created
        public bool IsActive { get; set; } // Indicates if the user account is active or not

        // Navigation properties for relationships
        public ICollection<Course> Courses { get; set; } // Courses the user is enrolled in
        public ICollection<Enrollment> Enrollments { get; set; } // All enrollments related to the user
    }
}