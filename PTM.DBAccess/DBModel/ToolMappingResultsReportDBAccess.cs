using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.DBAccess.DBModel
{
    public static class ToolMappingResultsReportDBAccess
    {
        //default report
        public static ToolMappingResultHeader getToolMappingResultsHeaderData()
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {


                    var result = (from mh in db.MappingHistories
                                  join ul in db.UserLogins on mh.UserId equals ul.UserId
                                  select new
                                  {
                                      mh.MappingId,
                                      mh.MappingPercentage,
                                      mh.Date,
                                      mh.NewToolId,
                                      mh.OldToolId,
                                      ul.UserFullName
                                  }).OrderByDescending(x => x.MappingId).FirstOrDefault();

                    var fromTool = db.PMTools.Where(x => x.ToolId == result.OldToolId).FirstOrDefault();
                    var toTool = db.PMTools.Where(x => x.ToolId == result.NewToolId).FirstOrDefault();


                    ToolMappingResultHeader toolMappingResultHeader = new ToolMappingResultHeader()
                    {
                        MappedBy = result.UserFullName,
                        MappedDate = result.Date,
                        MappingFrom = fromTool.ToolName,
                        MappingTo = toTool.ToolName,
                        MappingPercentage = result.MappingPercentage


                    };



                    return toolMappingResultHeader;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public static List<ToolMapperResultDetails> getToolMappingResultsMappingData()
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    var latestRecord = db.MappingHistories.OrderByDescending(u => u.MappingId).FirstOrDefault();

                    var result = (from mh in db.MappingHistoryDetails
                                  join af in db.AllFeatures on mh.FeatureId equals af.FeatureId
                                  where mh.MappingId == latestRecord.MappingId
                                  select (

                                      new ToolMapperResultDetails
                                      {

                                          featureName = af.FeatureName,
                                          fromToolYesNo = mh.OldToolYesNo,
                                          toToolYesNo = mh.NewToolYesNo
                                      }
                                  )).Distinct().ToList();




                    return result;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //custom report
        public static ToolMappingResultHeader getToolMappingResultsHeaderDataCustom(long selecttedReport)
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {


                    var result = (from mh in db.MappingHistories
                                  join ul in db.UserLogins on mh.UserId equals ul.UserId
                                  select new
                                  {
                                      mh.MappingId,
                                      mh.MappingPercentage,
                                      mh.Date,
                                      mh.NewToolId,
                                      mh.OldToolId,
                                      ul.UserFullName
                                  }).Where(x => x.MappingId == selecttedReport).FirstOrDefault();

                    var fromTool = db.PMTools.Where(x => x.ToolId == result.OldToolId).FirstOrDefault();
                    var toTool = db.PMTools.Where(x => x.ToolId == result.NewToolId).FirstOrDefault();


                    ToolMappingResultHeader toolMappingResultHeader = new ToolMappingResultHeader()
                    {
                        MappedBy = result.UserFullName,
                        MappedDate = result.Date,
                        MappingFrom = fromTool.ToolName,
                        MappingTo = toTool.ToolName,
                        MappingPercentage = result.MappingPercentage


                    };



                    return toolMappingResultHeader;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public static List<ToolMapperResultDetails> getToolMappingResultsMappingDataCustom(long selecttedReport)
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    var latestRecord = db.MappingHistories.Where(u => u.MappingId == selecttedReport).FirstOrDefault();

                    var result = (from mh in db.MappingHistoryDetails
                                  join af in db.AllFeatures on mh.FeatureId equals af.FeatureId
                                  where mh.MappingId == latestRecord.MappingId
                                  select (

                                      new ToolMapperResultDetails
                                      {

                                          featureName = af.FeatureName,
                                          fromToolYesNo = mh.OldToolYesNo,
                                          toToolYesNo = mh.NewToolYesNo
                                      }
                                  )).Distinct().ToList();




                    return result;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        public static List<PMtoolModel> getToolMappingDropdown()
        {

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    List<PMtoolModel> pMtoolModel = new List<PMtoolModel>();

                    var mappings = db.MappingHistories.ToList();

                    foreach (var mapping in mappings)
                    {


                        var fromPMTool = db.PMTools.Where(x => x.ToolId == mapping.OldToolId).SingleOrDefault();
                        var toPMTool = db.PMTools.Where(x => x.ToolId == mapping.NewToolId).SingleOrDefault();

                        PMtoolModel pMtoolModel1 = new PMtoolModel()
                        {

                            ToolId = (int)mapping.MappingId,
                            ToolName = fromPMTool.ToolName + "->" + toPMTool.ToolName + " -> " + mapping.Date

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

    }
}
