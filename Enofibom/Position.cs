//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enofibom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Position
    {
        public int Id { get; set; }
        public string IMSI { get; set; }
        public string MSISDN { get; set; }
        public string CGI { get; set; }
        public string Kind { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Radius { get; set; }
        public string PlanName { get; set; }
        public Nullable<System.DateTime> locStamp { get; set; }
        public string AngleStart { get; set; }
        public string AngleEnd { get; set; }
        public string IMEI { get; set; }
        public Nullable<System.DateTime> eventStamp { get; set; }
        public string TAC { get; set; }
    }
}
