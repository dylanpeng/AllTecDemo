using EFCodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirst
{
    public class ProviceConfiguration : EntityTypeConfiguration<Provice>
    {
        public ProviceConfiguration()
        {
            ToTable("provice")                                                  //映射表
                .HasKey(q => q.ProviceId)                                       //指定主键
                .HasMany(q => q.Citys).WithRequired(q => q.ProviceData).HasForeignKey(q => q.ProviceId);        //配置一对多关系
        }
    }
}
