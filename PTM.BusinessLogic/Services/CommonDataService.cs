using PTM.DBAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.BusinessLogic.Services
{
    public static class CommonDataService
    {
        public static List<PMTool> getPMToolList()
        {

            return PMTDataAccess.getPMTools();

        }
    }
}
