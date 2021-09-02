using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.DBAccess.DBModel
{
    public static class ToolMigrationResultsReportDBAccess
    {
        public static List<PMtoolModel> getToolMappingDropdown()
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    List<PMtoolModel> pMtoolModel = new List<PMtoolModel>();

                    var migrations = db.MigrationHistories.ToList();

                    foreach (var migratin in migrations)
                    {


                        var fromPMTool = db.PMTools.Where(x => x.ToolId == migratin.OldToolId).SingleOrDefault();
                        var toPMTool = db.PMTools.Where(x => x.ToolId == migratin.NewToolId).SingleOrDefault();

                        PMtoolModel pMtoolModel1 = new PMtoolModel()
                        {

                            ToolId = (int)migratin.MigrationId,
                            ToolName = fromPMTool.ToolName + "->" + toPMTool.ToolName + " -> " + migratin.Date

                        };

                        pMtoolModel.Add(pMtoolModel1);

                    }


                    pMtoolModel.OrderBy(x => x.ToolName);

                    return pMtoolModel;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static ToolMigrationDetails getToolMigrationResultsMappingData()
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {


                    var result = (from mh in db.MigrationHistories
                                  join ul in db.UserLogins on mh.UserId equals ul.UserId
                                  select new
                                  {
                                      mh.MigrationId,
                                      mh.MigrationPercentage,
                                      mh.Date,
                                      mh.NewToolId,
                                      mh.OldToolId,
                                      ul.UserFullName
                                  }).OrderByDescending(x => x.MigrationId).FirstOrDefault();

                    var fromTool = db.PMTools.Where(x => x.ToolId == result.OldToolId).FirstOrDefault();
                    var toTool = db.PMTools.Where(x => x.ToolId == result.NewToolId).FirstOrDefault();


                    ToolMigrationDetails toolMigrationDetails = new ToolMigrationDetails()
                    {

                        Date = result.Date,
                        FromTool = fromTool.ToolName,
                        ToTool = toTool.ToolName,
                        User = result.UserFullName


                    };



                    return toolMigrationDetails;

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static ToolMigrationDetails getToolMigrationResultsMappingDataCustom(long selecttedReport)
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {


                    var result = (from mh in db.MigrationHistories
                                  join ul in db.UserLogins on mh.UserId equals ul.UserId
                                  select new
                                  {
                                      mh.MigrationId,
                                      mh.MigrationPercentage,
                                      mh.Date,
                                      mh.NewToolId,
                                      mh.OldToolId,
                                      ul.UserFullName
                                  }).Where(x => x.MigrationId == selecttedReport).FirstOrDefault();

                    var fromTool = db.PMTools.Where(x => x.ToolId == result.OldToolId).FirstOrDefault();
                    var toTool = db.PMTools.Where(x => x.ToolId == result.NewToolId).FirstOrDefault();


                    ToolMigrationDetails toolMigrationDetails = new ToolMigrationDetails()
                    {

                        Date = result.Date,
                        FromTool = fromTool.ToolName,
                        ToTool = toTool.ToolName,
                        User = result.UserFullName


                    };



                    return toolMigrationDetails;

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }




}
