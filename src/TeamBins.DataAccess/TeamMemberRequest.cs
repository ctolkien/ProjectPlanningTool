//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamBins.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeamMemberRequest
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }
        public int TeamID { get; set; }
        public string ActivationCode { get; set; }
        public int CreatedByID { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}
