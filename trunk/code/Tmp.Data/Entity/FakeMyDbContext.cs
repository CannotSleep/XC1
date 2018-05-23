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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class FakeMyDbContext : IMyDbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountOfRoles> AccountOfRoles { get; set; }
        public DbSet<BuildingModel> BuildingModels { get; set; }
        public DbSet<CodeTable> CodeTables { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<ErrorInfo> ErrorInfoes { get; set; }
        public DbSet<FileMange> FileManges { get; set; }
        public DbSet<FileModular> FileModulars { get; set; }
        public DbSet<GanttLink> GanttLinks { get; set; }
        public DbSet<GanttTask> GanttTasks { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<ModelInfo> ModelInfoes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<ProjectInfo> ProjectInfoes { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<VersionControl> VersionControls { get; set; }

        public FakeMyDbContext()
        {
            Accounts = new FakeDbSet<Account>("ID");
            AccountOfRoles = new FakeDbSet<AccountOfRoles>("ID");
            BuildingModels = new FakeDbSet<BuildingModel>("ID");
            CodeTables = new FakeDbSet<CodeTable>("ID");
            Departments = new FakeDbSet<Departments>("ID");
            ErrorInfoes = new FakeDbSet<ErrorInfo>("ID");
            FileManges = new FakeDbSet<FileMange>("FileID");
            FileModulars = new FakeDbSet<FileModular>("FileModularID");
            GanttLinks = new FakeDbSet<GanttLink>("Id");
            GanttTasks = new FakeDbSet<GanttTask>("Id");
            Menus = new FakeDbSet<Menus>("ID");
            ModelInfoes = new FakeDbSet<ModelInfo>("ID");
            Permissions = new FakeDbSet<Permission>("ID");
            ProjectInfoes = new FakeDbSet<ProjectInfo>("ID");
            Roles = new FakeDbSet<Roles>("ID");
            Schedules = new FakeDbSet<Schedule>("ID");
            sysdiagrams = new FakeDbSet<sysdiagrams>("diagramid");
            VersionControls = new FakeDbSet<VersionControl>("Key");

            InitializePartial();
        }
        
        public int SaveChangesCount { get; private set; } 
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }
}
// </auto-generated>
