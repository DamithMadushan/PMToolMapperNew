using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Model.Models
{
    public class MappingHistoryDetail
    {
        public long DetailId { get; set; }
        public Nullable<long> MappingId { get; set; }
        public Nullable<long> FeatureId { get; set; }
        public string OldToolYesNo { get; set; }
        public string NewToolYesNo { get; set; }
    }
}
