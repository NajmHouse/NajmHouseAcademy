using NajmHouseAPI.Domian.Entity;
using NajmHouseAPI.Domian.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NajmHouseAPI.Domian.Interface
{
    public interface ICourseRepository: IBaseRepository<Course>
    {
        //Task<IEnumerable<Course>> GetAllAsync();
        //Task<Course> GetByIdAsync(int id);
        //Task<Course> FindAsync(Expression<Func<Course, bool>> predicate);
    }
}
