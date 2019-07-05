using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess
{
    public interface ITeacherRepository : IEmployeeRepository<Teacher>
    {
        Task<Teacher> GetWithCourses(long id);
    }
}
