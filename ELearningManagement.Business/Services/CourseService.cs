using ELearningManagement.Data.Repositories;
using ELearningManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningManagement.Business.Services
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _courseRepository;

        public CourseService(IRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _courseRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            var courses = await _courseRepository.GetAllAsync();
            return courses.Where(c => c.IsPublished).ToList();
        }

        public async Task<IEnumerable<Course>> GetCoursesByUserAsync(string userId)
        {
            return await _courseRepository.FindAsync(c => c.CreatedById == userId);
        }

        public async Task CreateCourseAsync(Course course)
        {
            course.CreatedDate = DateTime.Now;
            course.IsPublished = false;
            await _courseRepository.AddAsync(course);
        }

        public async Task UpdateCourseAsync(Course course)
        {
            course.UpdatedDate = DateTime.Now;
            await _courseRepository.UpdateAsync(course);
        }

        public async Task DeleteCourseAsync(int courseId)
        {
            var course = await _courseRepository.GetByIdAsync(courseId);
            if (course != null)
            {
                await _courseRepository.DeleteAsync(course);
            }
        }

        public async Task PublishCourseAsync(int courseId)
        {
            var course = await _courseRepository.GetByIdAsync(courseId);
            if (course != null)
            {
                course.IsPublished = true;
                await _courseRepository.UpdateAsync(course);
            }
        }
    }
}