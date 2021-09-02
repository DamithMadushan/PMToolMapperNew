using PTM.DBAccess.DBModel;
using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.BusinessLogic.Services
{
    public static class ToolMigrationReportService
    {
        public static List<PMtoolModel> getToolMappingDrp()
        {

            return ToolMigrationResultsReportDBAccess.getToolMappingDropdown();

        }



        public static ToolMigrationDetails gettoolMappingResultDetails()
        {

            return ToolMigrationResultsReportDBAccess.getToolMigrationResultsMappingData();

        }


        public static ToolMigrationDetails gettoolMigrationResultDetailsCustom(long selecttedReport)
        {

            return ToolMigrationResultsReportDBAccess.getToolMigrationResultsMappingDataCustom(selecttedReport);

        }
    }
}
