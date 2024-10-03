using NajmHouseAPI.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajmHouseAPI.Application.Interfaces
{
    public interface ICourseServices
    {
        public List<CourseViewModel> GetAllCourses();
    }
}
