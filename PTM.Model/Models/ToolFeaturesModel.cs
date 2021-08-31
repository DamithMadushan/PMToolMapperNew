using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Model.Models
{
    public class ToolFeaturesModel
    {
        public int Id { get; set; }

        public int FeatureId { get; set; }

        public int FeatureCategoryId { get; set; }

        public int ToolId { get; set; }

        public string FeatureUrl { get; set; }

        public string FeatureStatus { get; set; }

        public string Date { get; set; }
    }
}
