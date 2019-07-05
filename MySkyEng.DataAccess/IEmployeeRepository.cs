using MySkyEng.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess
{
    public interface IEmployeeRepository<TEmployee> : IPersonRepository<TEmployee> where TEmployee : IEmployee
    {
        Task<IEnumerable<TEmployee>> GetByExperience(int exp);
    }
}
