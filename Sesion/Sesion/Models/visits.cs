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
    
    public partial class visits
    {
        public int visitId { get; set; }
        public Nullable<int> apartmentId { get; set; }
        public string visitName { get; set; }
        public string visitLastName { get; set; }
        public string visitIdentificationCard { get; set; }
        public System.DateTime visitDate { get; set; }
    
        public virtual apartments apartments { get; set; }
    }
}