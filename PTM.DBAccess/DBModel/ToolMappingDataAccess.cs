using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.DBAccess.DBModel
{
    public static class ToolMappingDataAccess
    {

        /// <summary>
        /// Get Common Features
        /// </summary>
        /// <param name="fromName"></param>
        /// <param name="toName"></param>
        /// <param name="feature Cat Id"></param>
        /// <returns></returns>
        public static async Task<List<ToolMappingDataModel>> commonFeatures(string fromName, string toName, long featCatId, long mappingId)
        {
            //data set model
            List<ToolMappingDataModel> toolMappingDataSet = new List<ToolMappingDataModel>();

            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    long frmId = await db.PMTools.Where(x => x.ToolName == fromName).Select(x => x.ToolId).SingleOrDefaultAsync();
                    long toId = await db.PMTools.Where(x => x.ToolName == toName).Select(x => x.ToolId).SingleOrDefaultAsync();


                    //get all feature names
                    var toolFearutes = await (from tf in db.ToolFeatures
                                              join af in db.AllFeatures on tf.FeatureId equals af.FeatureId
                                              where (tf.ToolId == frmId || tf.ToolId == toId) && tf.FeatureCategoryId == featCatId
                                              select new
                                              {
                                                  af.FeatureId,
                                                  af.FeatureName,

                                              }).GroupBy(x => x.FeatureId).ToListAsync();



                    foreach (var toolFeature in toolFearutes)
                    {
                        ToolMappingDataModel toolMappingData = new ToolMappingDataModel();


                        foreach (var i in toolFeature)
                        {


                            long frmToolFeatureId = await db.ToolFeatures.Where(x => x.FeatureId == i.FeatureId && x.ToolId == frmId && x.FeatureCategoryId == featCatId).Select(x => x.Id).FirstOrDefaultAsync();
                            long toToolFeatureId = await db.ToolFeatures.Where(x => x.FeatureId == i.FeatureId && x.ToolId == toId && x.FeatureCategoryId == featCatId).Select(x => x.Id).FirstOrDefaultAsync();

                            toolMappingData.FeatureName = i.FeatureName;
                            toolMappingData.FeatureId = i.FeatureId;
                            toolMappingData.FromToolName = fromName;
                            toolMappingData.ToToolName = toName;


                            if (frmToolFeatureId > 0)
                            {
                                toolMappingData.FromToolYesNo = "Yes";
                            }
                            else
                            {
                                toolMappingData.FromToolYesNo = "No";
                            }

                            if (toToolFeatureId > 0)
                            {
                                toolMappingData.ToToolYesNo = "Yes";

                            }
                            else
                            {
                                toolMappingData.ToToolYesNo = "No";
                            }


                            MappingHistoryDetail mappingHistoryDetail = new MappingHistoryDetail()
                            {
                                FeatureId = toolMappingData.FeatureId,
                                MappingId = mappingId,
                                NewToolYesNo = toolMappingData.ToToolYesNo,
                                OldToolYesNo = toolMappingData.FromToolYesNo
                            };


                            //insert mapping data
                            db.MappingHistoryDetails.Add(mappingHistoryDetail);
                            await db.SaveChangesAsync();



                        }


                        toolMappingDataSet.Add(toolMappingData);

                    }






                    return toolMappingDataSet;


                }

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }



        public static long insertMappingID(string fromName, string toName)
        {
            try
            {


                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    long frmId = db.PMTools.Where(x => x.ToolName == fromName).Select(x => x.ToolId).SingleOrDefault();
                    long toId = db.PMTools.Where(x => x.ToolName == toName).Select(x => x.ToolId).SingleOrDefault();

                    MappingHistory mappingHistory = new MappingHistory()
                    {

                        OldToolId = frmId,
                        NewToolId = toId,
                        UserId = UserDataModel.UserId,
                        Date = DateTime.Now.ToString()


                    };


                    db.MappingHistories.Add(mappingHistory);

                    db.SaveChanges();

                    return mappingHistory.MappingId;
                }




            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void updateMappingPercentage(string percentage, long mappingId)
        {
            try
            {

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    db.MappingHistories.First(x => x.MappingId == mappingId).MappingPercentage = percentage;
                    db.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
