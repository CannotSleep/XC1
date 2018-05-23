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
    // ModelInfo
    public partial class ModelInfo: BaseEntity
    {

        ///<summary>
        /// 主键
        ///</summary>
        public Guid ID { get; set; } // ID (Primary key)

        ///<summary>
        /// 模型名称
        ///</summary>
        public string ModelName { get; set; } // ModelName

        ///<summary>
        /// 模型类型(机电，结构，建筑。。)
        ///</summary>
        public int? ModelType { get; set; } // ModelType

        ///<summary>
        /// 维护人员
        ///</summary>
        public Guid? ModelManagerID { get; set; } // ModelManagerID

        ///<summary>
        /// 简介
        ///</summary>
        public string ModelSummary { get; set; } // ModelSummary

        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime { get; set; } // CreateTime

        ///<summary>
        /// 所属项目
        ///</summary>
        public Guid? ProjectID { get; set; } // ProjectID
        
        public ModelInfo()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
