using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkyEng.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySkyEng.Data.Configurations
{
    class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Course);
        }
    }
}
