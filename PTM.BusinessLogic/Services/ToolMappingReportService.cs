using PTM.DBAccess.DBModel;
using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.BusinessLogic.Services
{
    public static class ToolMappingReportService
    {
        /// <summary>
        /// default report
        /// </summary>
        /// <returns></returns>
        public static ToolMappingResultHeader gettoolMappingResultHeader() {

            return ToolMappingResultsReportDBAccess.getToolMappingResultsHeaderData();

        }

        public static List<ToolMapperResultDetails> gettoolMappingResultDetails()
        {

            return ToolMappingResultsReportDBAccess.getToolMappingResultsMappingData();

        }


        /// <summary>
        /// custom report
        /// </summary>
        /// <returns></returns>
        public static ToolMappingResultHeader gettoolMappingResultHeaderCustom(long selecttedReport)
        {

            return ToolMappingResultsReportDBAccess.getToolMappingResultsHeaderDataCustom(selecttedReport);

        }

        public static List<ToolMapperResultDetails> gettoolMappingResultDetailsCustom(long selecttedReport)
        {

            return ToolMappingResultsReportDBAccess.getToolMappingResultsMappingDataCustom(selecttedReport);

        }




        public static List<PMtoolModel> getToolMappingDrp()
        {

            return ToolMappingResultsReportDBAccess.getToolMappingDropdown();

        }

    }
}
