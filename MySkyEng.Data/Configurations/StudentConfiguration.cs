using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Configurations
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Gender);

            builder.HasOne(x => x.Country);

            builder.HasOne(x => x.Course);

            builder.HasOne(x => x.IntroductoryLesson);
        }
    }
}
