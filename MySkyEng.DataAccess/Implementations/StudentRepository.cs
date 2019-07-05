using MySkyEng.Data.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySkyEng.Data;

namespace MySkyEng.DataAccess.Implementations
{
    public class StudentRepository : PersonRepository<Student>, IStudentRepository
    {
        public StudentRepository(MySkyEngDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Student>> GetByLevel(string level)
        {
            return await context.Students.Where(x => x.LevelOfLanguage == level).AsNoTracking().ToArrayAsync();
        }
    }
}
