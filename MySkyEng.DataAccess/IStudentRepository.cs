using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess
{
    public interface IStudentRepository : IPersonRepository<Student>
    {
        Task<IEnumerable<Student>> GetByLevel(string level);
    }
}
