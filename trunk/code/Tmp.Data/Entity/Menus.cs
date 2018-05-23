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
    // tbLOG_Menus
    public partial class Menus: BaseEntity
    {
        public int ID { get; set; } // ID (Primary key)

        ///<summary>
        /// 父菜单ID
        ///</summary>
        public int ParentID { get; set; } // ParentID

        ///<summary>
        /// 名称
        ///</summary>
        public string Name { get; set; } // Name

        ///<summary>
        /// 菜单地址
        ///</summary>
        public string URL { get; set; } // URL

        ///<summary>
        /// 优先级
        ///</summary>
        public int Priority { get; set; } // Priority

        ///<summary>
        /// 是否启用
        ///</summary>
        public bool IsUse { get; set; } // IsUse
        public string Icon { get; set; } // Icon
        
        public Menus()
        {
            ParentID = 0;
            Name = "";
            URL = "";
            Priority = 0;
            IsUse = false;
            Icon = "0";
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>