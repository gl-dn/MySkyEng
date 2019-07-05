using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkyEng.Data.Entities;
using System;

namespace MySkyEng.Data.Configurations
{
    public class IntroductoryLessonConfiguration : IEntityTypeConfiguration<IntroductoryLesson>
    {
        public void Configure(EntityTypeBuilder<IntroductoryLesson> builder)
        {
            builder.ToTable("IntroductoryLesson");
            builder.HasKey(x => x.Id);
        }
    }
}
