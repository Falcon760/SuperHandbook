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
    
    public partial class CurrentStatu
    {
        public CurrentStatu()
        {
            this.Superheroes = new HashSet<Superhero>();
        }
    
        public int Id { get; set; }
        public string StatusType { get; set; }
    
        public virtual ICollection<Superhero> Superheroes { get; set; }
    }
}
