using Microsoft.EntityFrameworkCore.Storage;
using MySkyEng.Data;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace MySkyEng.DataAccess.Implementations
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MySkyEngDbContext context;
        private IDbContextTransaction transaction;
        private bool transactionClosed;
        private bool disposed = false;

        private IStudentRepository studentRepository;
        private ITeacherRepository teacherRepository;
        private IEmployeeRepository<Methodist> methodistRepository;
        private IRepository<Course> courseRepository;
        private IRepository<SimpleLesson> simpleLessonRepository;
        private IRepository<IntroductoryLesson> introductoryLessonRepository;
        private IRepository<Sale> saleRepository;

        public UnitOfWork(MySkyEngDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                if (studentRepository == null)
                    studentRepository = new StudentRepository(context);
                return studentRepository;
            }
        }

        public ITeacherRepository TeacherRepository
        {
            get
            {
                if (teacherRepository == null)
                    teacherRepository = new TeacherRepository(context);
                return teacherRepository;
            }
        }

        public IEmployeeRepository<Methodist> MethodistRepository
        {
            get
            {
                if (methodistRepository == null)
                    methodistRepository = new EmployeeRepository<Methodist>(context);
                return methodistRepository;
            }
        }

        public IRepository<Course> CourseRepository
        {
            get
            {
                if (courseRepository == null)
                    courseRepository = new Repository<Course>(context);
                return courseRepository;
            }
        }

        public IRepository<SimpleLesson> SimpleLessonRepository
        {
            get
            {
                if (simpleLessonRepository == null)
                    simpleLessonRepository = new Repository<SimpleLesson>(context);
                return simpleLessonRepository;
            }
        }

        public IRepository<IntroductoryLesson> IntroductoryLessonRepository
        {
            get
            {
                if (introductoryLessonRepository == null)
                    introductoryLessonRepository = new Repository<IntroductoryLesson>(context);
                return introductoryLessonRepository;
            }
        }

        public IRepository<Sale> SaleRepository
        {
            get
            {
                if (saleRepository == null)
                    saleRepository = new Repository<Sale>(context);
                return saleRepository;
            }
        }

        public void BeginTransaction()
        {
            if (transactionClosed || transaction == null)
            {
                transaction = context.Database.BeginTransaction();
                transactionClosed = false;
            }
        }

        public void CommitTransaction()
        {
            if (!transactionClosed)
            {
                transaction?.Commit();
                transactionClosed = true;
            }
        }

        public void RollbackTransaction()
        {
            if (!transactionClosed)
            {
                transaction?.Rollback();
                transactionClosed = true;
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
