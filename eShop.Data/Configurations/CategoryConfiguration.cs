using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Configurations {
    public class CategoryConfiguration : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {
            builder.ToTable("Categories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.IsShowOnHome);
            builder.Property(x => x.ParentId);
            builder.Property(x => x.SortOrder);
        }
    }
}
