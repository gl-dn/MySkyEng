using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Configurations
{
    class SimpleLessonConfiguration : IEntityTypeConfiguration<SimpleLesson>
    {
        public void Configure(EntityTypeBuilder<SimpleLesson> builder)
        {
            builder.ToTable("SimpleLesson");
            builder.HasKey(x => x.Id);
        }
    }
}
