using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Model.Models
{
    public  class MappingHistoryModel
    {
        public long MappingId { get; set; }
        public Nullable<long> OldToolId { get; set; }
        public Nullable<long> NewToolId { get; set; }
        public Nullable<long> UserId { get; set; }
        public string Date { get; set; }
        public string MappingPercentage { get; set; }

    }
}
