//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wyplata
    {
        public int IdWyplata { get; set; }
        public Nullable<double> Zus { get; set; }
        public Nullable<double> Dochodowy { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<double> PlacaNetto { get; set; }
        public Nullable<int> IdPracownika { get; set; }
        public Nullable<double> Emerytalna { get; set; }
        public Nullable<double> rentowa { get; set; }
        public Nullable<double> chorobowa { get; set; }
    
        public virtual Table Table { get; set; }
    }
}
