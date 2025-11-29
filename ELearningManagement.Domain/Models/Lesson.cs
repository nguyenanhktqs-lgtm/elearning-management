using System;
using System.Collections.Generic;

namespace ELearningManagement.Domain.Models
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relationships
        public virtual Course Course { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
    }
}