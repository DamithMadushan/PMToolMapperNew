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
    
    public partial class MappingHistoryDetail
    {
        public long DetailId { get; set; }
        public Nullable<long> MappingId { get; set; }
        public Nullable<long> FeatureId { get; set; }
        public string OldToolYesNo { get; set; }
        public string NewToolYesNo { get; set; }
    
        public virtual AllFeature AllFeature { get; set; }
        public virtual MappingHistory MappingHistory { get; set; }
    }
}