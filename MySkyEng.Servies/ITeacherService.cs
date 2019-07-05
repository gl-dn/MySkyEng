using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.Servies
{
    public interface ITeacherService
    {
        Task<IEnumerable<Teacher>> GetByName(string name);

        Task<IEnumerable<Teacher>> GetByGender(string gender);
        Task<IEnumerable<Teacher>> GetByCountry(string country);
        Task<IEnumerable<Teacher>> GetByAge(int age);

        Task<IEnumerable<Teacher>> GetByExperience(int exp);
        Task<Teacher> GetWithCourses(long id);
    }
}
