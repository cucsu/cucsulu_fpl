//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HopNguyenModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypePage
    {
        public TypePage()
        {
            this.Pages = new HashSet<Page>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> AdminId { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual ICollection<Page> Pages { get; set; }
    }
}