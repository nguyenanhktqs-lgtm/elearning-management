using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELearningManagement.Domain.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        public int LessonId { get; set; }
        
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        [Required]
        [StringLength(1024)]
        public string FilePath { get; set; }

        [Required]
        [StringLength(50)]
        public string FileType { get; set; }

        [Required]
        public long FileSize { get; set; }

        [Required]
        public DateTime UploadedDate { get; set; }

        [ForeignKey("LessonId")]
        public virtual Lesson Lesson { get; set; }
    }
}