using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Configurations
{
    public class MethodistConfiguration : IEntityTypeConfiguration<Methodist>
    {
        public void Configure(EntityTypeBuilder<Methodist> builder)
        {
            builder.ToTable("Methodist");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Gender);

            builder.HasOne(x => x.Country);

            builder.HasMany(x => x.IntroductoryLessons);
        }
    }
}
