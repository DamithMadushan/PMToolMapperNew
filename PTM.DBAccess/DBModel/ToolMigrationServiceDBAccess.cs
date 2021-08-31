using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.DBAccess.DBModel
{
    public static class ToolMigrationServiceDBAccess
    {

        public static List<PMtoolModel> getToolDropdown()
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {


                    var result = (from pmt in db.PMTools
                                  select (

                                      new PMtoolModel
                                      {
                                          ToolId = (int)pmt.ToolId,
                                          ToolName = pmt.ToolName
                                      }
                                  )).OrderBy(x => x.ToolName).ToList();



                    return result;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
