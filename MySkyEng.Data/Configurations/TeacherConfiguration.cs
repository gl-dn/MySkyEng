using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Configurations
{
    class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Gender);

            builder.HasOne(x => x.Country);

            builder.HasMany(x => x.Courses);
        }
    }
}
