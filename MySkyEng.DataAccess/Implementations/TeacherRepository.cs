using MySkyEng.Data.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySkyEng.Data;

namespace MySkyEng.DataAccess.Implementations
{
    public class TeacherRepository : EmployeeRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(MySkyEngDbContext context) : base(context)
        { }

        public async Task<Teacher> GetWithCourses(long id)
        {
            return await context.Teachers.Where(x => x.Id == id).Include(x => x.Courses).AsNoTracking().FirstOrDefaultAsync();
        }
    }
}
