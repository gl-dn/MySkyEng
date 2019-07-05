using MySkyEng.Data.Entities;
using MySkyEng.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.Servies.Implementations
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork Uow;

        public TeacherService(IUnitOfWork Uow)
        {
            this.Uow = Uow;
        }

        public async Task<IEnumerable<Teacher>> GetByAge(int age)
        {
            return await Uow.TeacherRepository.GetByAge(age);
        }

        public async Task<IEnumerable<Teacher>> GetByCountry(string country)
        {
            return await Uow.TeacherRepository.GetByCountry(country);
        }

        public async Task<IEnumerable<Teacher>> GetByGender(string gender)
        {
            return await Uow.TeacherRepository.GetByGender(gender);
        }

        public async Task<Teacher> GetById(long id)
        {
            return await Uow.TeacherRepository.GetById(id);
        }

        public async Task<IEnumerable<Teacher>> GetByName(string name)
        {
            return await Uow.TeacherRepository.GetByName(name);
        }

        public async Task<IEnumerable<Teacher>> GetByExperience(int exp)
        {
            return await Uow.TeacherRepository.GetByExperience(exp);
        }

        public async Task<Teacher> GetWithCourses(long id)
        {
            return await Uow.TeacherRepository.GetWithCourses(id);
        }
    }
}
