using System;
using System.Collections.Generic;
using EFCodeFirst.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirst
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("city")
            .HasKey(q => q.CityId)
            .Property(q => q.ProviceId).IsRequired();
        }
    }
}
