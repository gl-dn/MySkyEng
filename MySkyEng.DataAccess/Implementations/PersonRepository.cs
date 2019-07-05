using Microsoft.EntityFrameworkCore;
using MySkyEng.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess.Implementations
{
    public class PersonRepository<TPerson> : Repository<TPerson>, IPersonRepository<TPerson> where TPerson : class, IPerson
    {
        public PersonRepository(MySkyEngDbContext context) : base(context)
        { }

        public async Task<IEnumerable<TPerson>> GetByName(string name)
        {
            return await context.Set<TPerson>().Where(x => $"{x.FirstName} {x.LastName}".Contains(name)).AsNoTracking().ToArrayAsync();
        }

        public async Task<IEnumerable<TPerson>> GetByAge(int age)
        {
            return await context.Set<TPerson>().Where(x => x.Age >= age).AsNoTracking().ToArrayAsync();
        }

        public async Task<IEnumerable<TPerson>> GetByCountry(string country)
        {
            return await context.Set<TPerson>().Where(x => x.Country.Title.Contains(country)).AsNoTracking().ToArrayAsync();
        }

        public async Task<IEnumerable<TPerson>> GetByGender(string gender)
        {
            return await context.Set<TPerson>().Where(x => x.Gender.Title.Contains(gender)).AsNoTracking().ToArrayAsync();
        }
    }
}
