using PTM.DBAccess.DBModel;
using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.BusinessLogic.Services
{
    public static class ToolMappingService
    {
        static string frmName = MappingTempData.fromToolName;
        static string toName = MappingTempData.toToolName;
   
        public static async Task<List<ToolMappingDataModel>> getCommonBasicFeatures(long mappingId)
        {
            return await ToolMappingDataAccess.commonFeatures(frmName, toName,1, mappingId);

        }

        public static async Task<List<ToolMappingDataModel>> getCommonAdvancedFeatures(long mappingId)
        {
  
            return await ToolMappingDataAccess.commonFeatures(frmName, toName,2, mappingId);
        }

        public static async Task<List<ToolMappingDataModel>> getExtraFeatures(long mappingId)
        {
    
            return await ToolMappingDataAccess.commonFeatures(frmName, toName,3, mappingId);
        }


        public static long insertMappingID()
        {
            return ToolMappingDataAccess.insertMappingID(frmName, toName);
        }


        public static void updateMappingPercentage(string percentage,long mappingId)
        {
            ToolMappingDataAccess.updateMappingPercentage(percentage, mappingId);
        }


    }
}
