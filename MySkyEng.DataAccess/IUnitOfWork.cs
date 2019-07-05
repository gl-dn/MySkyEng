using MySkyEng.Data;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess
{
    public interface IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        IEmployeeRepository<Methodist> MethodistRepository { get; }
        IRepository<Course> CourseRepository { get; }
        IRepository<SimpleLesson> SimpleLessonRepository { get; }
        IRepository<IntroductoryLesson> IntroductoryLessonRepository { get; }
        IRepository<Sale> SaleRepository { get; }

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        Task<int> SaveChangesAsync();
    }
}
