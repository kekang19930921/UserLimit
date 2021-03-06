//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LYZJ.UserLimitMVC.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BasePermissionGroup
    {
        public BasePermissionGroup()
        {
            this.GroupType = 1;
            this.AllowEdit = 1;
            this.AllowDelete = 1;
            this.IsVisible = 1;
            this.DeletionStateCode = 0;
            this.Enabled = 1;
            this.R_Group_Permission = new HashSet<R_Group_Permission>();
            this.R_Group_User = new HashSet<R_Group_User>();
            this.R_Group_Role = new HashSet<R_Group_Role>();
        }
    
        public int ID { get; set; }
        public string GroupName { get; set; }
        public short GroupType { get; set; }
        public Nullable<int> AllowEdit { get; set; }
        public Nullable<int> AllowDelete { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public Nullable<int> SortCode { get; set; }
        public Nullable<short> DeletionStateCode { get; set; }
        public Nullable<int> Enabled { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string CreateUserID { get; set; }
        public string CreateBy { get; set; }
        public string ModifiedUserID { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<R_Group_Permission> R_Group_Permission { get; set; }
        public virtual ICollection<R_Group_User> R_Group_User { get; set; }
        public virtual ICollection<R_Group_Role> R_Group_Role { get; set; }
    }
}
