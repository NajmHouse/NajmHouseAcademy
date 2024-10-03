using NajmHouseAPI.Application.Interfaces;
using NajmHouseAPI.Application.ViewModel;
using NajmHouseAPI.Domian.Interface;

namespace NajmHouseAPI.Application.Services
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _coursesRepository;
        public CourseServices(ICourseRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }
        public List<CourseViewModel> GetAllCourses()
        {
            var result = _coursesRepository.GetAll();
            List<CourseViewModel> courseList = new List<CourseViewModel>();

            foreach(var course in result) 
            {
                var coursemodel = new CourseViewModel()
                {
                    CreatedBy = course.CreatedBy,
                    CreatedDate = course.CreatedDate,
                    Description = course.Description,
                    Id = course.Id,
                    IsActive = course.IsActive,
                    Name = course.Name,
                    UpdatedBy = course.UpdatedBy
                };
                courseList.Add(coursemodel);
            }
            return courseList;
        }
    }
}
