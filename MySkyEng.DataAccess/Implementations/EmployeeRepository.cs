using Microsoft.EntityFrameworkCore;
using MySkyEng.Data;
using MySkyEng.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess.Implementations
{
    public class EmployeeRepository<TEmployee> : PersonRepository<TEmployee>, IEmployeeRepository<TEmployee> where TEmployee : class, IEmployee
    {
        public EmployeeRepository(MySkyEngDbContext context) : base(context)
        { }

        public async Task<IEnumerable<TEmployee>> GetByExperience(int exp)
        {
            return await context.Set<TEmployee>().Where(x => x.Experience >= exp).AsNoTracking().ToArrayAsync();
        }
    }
}
