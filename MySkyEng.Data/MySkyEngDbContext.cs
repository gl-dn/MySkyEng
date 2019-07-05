using Microsoft.EntityFrameworkCore;
using MySkyEng.Data.Configurations;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data
{
    public class MySkyEngDbContext : DbContext
    {
        public MySkyEngDbContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration())
                        .ApplyConfiguration(new IntroductoryLessonConfiguration())
                        .ApplyConfiguration(new MethodistConfiguration())
                        .ApplyConfiguration(new SaleConfiguration())
                        .ApplyConfiguration(new SimpleLessonConfiguration())
                        .ApplyConfiguration(new StudentConfiguration())
                        .ApplyConfiguration(new TeacherConfiguration())
                        .ApplyConfiguration(new GenderConfiguration())
                        .ApplyConfiguration(new CountryConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<SimpleLesson> SimpleLessons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<IntroductoryLesson> IntroductoryLessons { get; set; }
        public DbSet<Methodist> Methodists { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
