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
    
    public partial class PMTool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMTool()
        {
            this.ToolFeatures = new HashSet<ToolFeature>();
            this.MappingHistories = new HashSet<MappingHistory>();
            this.MappingHistories1 = new HashSet<MappingHistory>();
            this.MigrationHistories = new HashSet<MigrationHistory>();
            this.MigrationHistories1 = new HashSet<MigrationHistory>();
        }
    
        public long ToolId { get; set; }
        public string ToolName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToolFeature> ToolFeatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MappingHistory> MappingHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MappingHistory> MappingHistories1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MigrationHistory> MigrationHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MigrationHistory> MigrationHistories1 { get; set; }
    }
}
