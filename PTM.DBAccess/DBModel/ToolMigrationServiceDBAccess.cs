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

        public static long insertMigration(string fromName, string toName)
        {
            try
            {


                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    long frmId = db.PMTools.Where(x => x.ToolName == fromName).Select(x => x.ToolId).SingleOrDefault();
                    long toId = db.PMTools.Where(x => x.ToolName == toName).Select(x => x.ToolId).SingleOrDefault();

                    MigrationHistory migration = new MigrationHistory()
                    {

                        OldToolId = frmId,
                        NewToolId = toId,
                        UserId = UserDataModel.UserId,
                        Date = DateTime.Now.ToString()


                    };


                    db.MigrationHistories.Add(migration);

                    db.SaveChanges();

                    return migration.MigrationId;
                }




            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
