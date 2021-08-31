
using PTM.DBAccess.DBModel;
using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.BusinessLogic.Services
{
    public static class ToolMigrationService
    {
        public static List<PMtoolModel> getToolMappingDrp()
        {

            return ToolMigrationServiceDBAccess.getToolDropdown();

        }
    }
}
