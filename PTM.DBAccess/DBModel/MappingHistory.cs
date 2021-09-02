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
    
    public partial class MappingHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MappingHistory()
        {
            this.MappingHistoryDetails = new HashSet<MappingHistoryDetail>();
        }
    
        public long MappingId { get; set; }
        public Nullable<long> OldToolId { get; set; }
        public Nullable<long> NewToolId { get; set; }
        public Nullable<long> UserId { get; set; }
        public string Date { get; set; }
        public string MappingPercentage { get; set; }
    
        public virtual PMTool PMTool { get; set; }
        public virtual UserLogin UserLogin { get; set; }
        public virtual PMTool PMTool1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MappingHistoryDetail> MappingHistoryDetails { get; set; }
    }
}