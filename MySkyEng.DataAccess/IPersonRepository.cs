using MySkyEng.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess
{
    public interface IPersonRepository<TPerson> : IRepository<TPerson> where TPerson : IPerson
    {
        Task<IEnumerable<TPerson>> GetByName(string name);

        Task<IEnumerable<TPerson>> GetByGender(string gender);
        Task<IEnumerable<TPerson>> GetByCountry(string country); 
        Task<IEnumerable<TPerson>> GetByAge(int age);
    }
}
