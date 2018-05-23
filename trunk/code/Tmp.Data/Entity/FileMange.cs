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
    // FileMange
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class FileMange: BaseEntity
    {
        public Guid FileID { get; set; } // FileID (Primary key)
        public string NameBefore { get; set; } // NameBefore
        public string NameNow { get; set; } // NameNow
        public string Date { get; set; } // Date
        public decimal? Size { get; set; } // Size
        public Guid? UserId { get; set; } // UserId
        public string FileType { get; set; } // FileType
        public string FilePath { get; set; } // FilePath
        public Guid? ProjectId { get; set; } // ProjectId
        public string FileCategory { get; set; } // FileCategory
        public string FileExplain { get; set; } // FileExplain
        public string UserName { get; set; } // UserName
        public string ProjectName { get; set; } // ProjectName

        // Reverse navigation
        public virtual ICollection<FileModular> FileModulars { get; set; } // FileModular.FileMange_FileModular_FileID
        
        public FileMange()
        {
            FileModulars = new List<FileModular>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
