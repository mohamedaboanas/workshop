//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vidzy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Genre
    {
        public Genre()
        {
            this.Videos = new HashSet<Video>();
        }
    
        public byte Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Video> Videos { get; set; }
    }
}
