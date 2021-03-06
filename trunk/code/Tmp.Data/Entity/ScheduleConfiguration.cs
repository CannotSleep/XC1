// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.0
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using Tmp.Core.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace Tmp.Data.Entity
{
    // Schedule
    public partial class ScheduleConfiguration : EntityTypeConfiguration<Schedule>
    {
        public ScheduleConfiguration()
            : this("dbo")
        {
        }
 
        public ScheduleConfiguration(string schema)
        {
            ToTable(schema + ".Schedule");
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("ID").IsRequired().HasColumnType("uniqueidentifier").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UserID).HasColumnName("UserID").IsOptional().HasColumnType("uniqueidentifier");
            Property(x => x.ModelInfoID).HasColumnName("ModelInfoID").IsOptional().HasColumnType("uniqueidentifier");
            Property(x => x.FilePath).HasColumnName("FilePath").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.FileName).HasColumnName("FileName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.Description).HasColumnName("Description").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.CreateTime).HasColumnName("CreateTime").IsOptional().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
