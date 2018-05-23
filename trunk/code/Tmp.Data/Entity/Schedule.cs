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
    public partial class Schedule: BaseEntity
    {
        public Guid ID { get; set; } // ID (Primary key)

        ///<summary>
        /// 上传用户
        ///</summary>
        public Guid? UserID { get; set; } // UserID

        ///<summary>
        /// BIM模型ID
        ///</summary>
        public Guid? ModelInfoID { get; set; } // ModelInfoID

        ///<summary>
        /// 上传路径
        ///</summary>
        public string FilePath { get; set; } // FilePath

        ///<summary>
        /// 文件名称
        ///</summary>
        public string FileName { get; set; } // FileName

        ///<summary>
        /// 备注
        ///</summary>
        public string Description { get; set; } // Description

        ///<summary>
        /// 上传时间
        ///</summary>
        public DateTime? CreateTime { get; set; } // CreateTime
        
        public Schedule()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
