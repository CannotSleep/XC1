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
    // sysdiagrams
    public partial class sysdiagramsConfiguration : EntityTypeConfiguration<sysdiagrams>
    {
        public sysdiagramsConfiguration()
            : this("dbo")
        {
        }
 
        public sysdiagramsConfiguration(string schema)
        {
            ToTable(schema + ".sysdiagrams");
            HasKey(x => x.diagramid);

            Property(x => x.name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(128);
            Property(x => x.principalid).HasColumnName("principal_id").IsRequired().HasColumnType("int");
            Property(x => x.diagramid).HasColumnName("diagram_id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.version).HasColumnName("version").IsOptional().HasColumnType("int");
            Property(x => x.definition).HasColumnName("definition").IsOptional().HasColumnType("varbinary");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
