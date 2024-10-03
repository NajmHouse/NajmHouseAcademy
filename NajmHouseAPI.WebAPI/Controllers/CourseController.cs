using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajmHouseAPI.Application.Interfaces;


namespace NajmHouseAPI.WebAPI.Controllers
{
    [Route("api/course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServices _services;
        public CourseController(ICourseServices services)
        {
            _services = services;
        }

        [HttpGet ("getallcourse")]
        public IActionResult  GetAllCourse() 
        {
            try
            {
                var response = _services.GetAllCourses();
                if (response.Count > 0)
                {
                    return Ok(response);
                }
                return NotFound(response);
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }
    }
}
