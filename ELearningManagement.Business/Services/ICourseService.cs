using ELearningManagement.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ELearningManagement.Business.Services
{
    public interface ICourseService
    {
        Task<Course> GetCourseByIdAsync(int id);
        Task<IEnumerable<Course>> GetAllCoursesAsync();
        Task<IEnumerable<Course>> GetCoursesByUserAsync(string userId);
        Task CreateCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(int courseId);
        Task PublishCourseAsync(int courseId);
    }
}