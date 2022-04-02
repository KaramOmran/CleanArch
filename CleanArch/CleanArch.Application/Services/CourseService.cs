using CleanArch.Application.Interfaces;
using CleanArch.Application.VIewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _CourseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _CourseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel {
                Courses = _CourseRepository.GetCourses()
            };
        }
    }
}
