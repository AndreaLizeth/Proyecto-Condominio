//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sesion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class complains
    {
        public int complainId { get; set; }
        public Nullable<int> userId { get; set; }
        public string complainDescription { get; set; }
        public System.DateTime complainDate { get; set; }
    
        public virtual users users { get; set; }
    }
}
