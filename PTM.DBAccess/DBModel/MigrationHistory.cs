//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTM.DBAccess.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class MigrationHistory
    {
        public long MigrationId { get; set; }
        public Nullable<long> OldToolId { get; set; }
        public Nullable<long> NewToolId { get; set; }
        public Nullable<long> UserId { get; set; }
        public string Date { get; set; }
        public string MigrationPercentage { get; set; }
    }
}
