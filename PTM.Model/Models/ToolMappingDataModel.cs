using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Model.Models
{
    public class ToolMappingDataModel
    {
        public string FeatureName { get; set; }
        public long FeatureId { get; set; }
        public long ToolFeatureId { get; set; }
        public long FromToolId { get; set; }
        public string FromToolName { get; set; }
        public string FromToolYesNo { get; set; }
        public string ToToolId { get; set; }
        public string ToToolName { get; set; }
        public string ToToolYesNo { get; set; }
    }
}
