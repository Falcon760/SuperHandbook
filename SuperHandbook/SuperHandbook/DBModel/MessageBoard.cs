//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperHandbook.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class MessageBoard
    {
        public MessageBoard()
        {
            this.Comments = new HashSet<Comment>();
            this.Issues = new HashSet<Issue>();
        }
    
        public int Id { get; set; }
        public string BoardName { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual Superhero Superhero { get; set; }
    }
}
