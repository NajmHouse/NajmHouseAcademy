using NajmHouseAPI.Domian.Entity;
using NajmHouseAPI.Domian.Interface;
using NajmHouseAPI.Infrastructure.Data.Models;
using NajmHouseAPI.Infrastructure.Data.Repository.Base;

namespace NajmHouseAPI.Infrastructure.Data.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        //private readonly NajmHouseContext _dbContext;
        public CourseRepository(NajmHouseContext dbContext) : base(dbContext)
        {
            //_dbContext = dbContext;
        }

    }
}
