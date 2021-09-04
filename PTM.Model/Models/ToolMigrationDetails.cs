using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Model.Models
{
    public class ToolMigrationDetails
    {
        public string FromTool { get; set; }
        public string ToTool { get; set; }
        public string Date { get; set; }
        public string User { get; set; }
        public string MigratedFrom { get; set; }
        public string MigratedTo { get; set; }

    }
}
