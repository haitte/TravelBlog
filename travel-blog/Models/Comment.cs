//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace travel_blog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public string CommentId { get; set; }
        public string Massage { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<int> Likes { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
