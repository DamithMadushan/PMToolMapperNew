using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.DBAccess.DBModel
{
    public static class PMTDataAccess
    {


        public static int insertOrUpdateTool(int tool_id, string toolName)
        {
            try
            {

                int status;

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    PMTool pMTool = db.PMTools.Where(x => x.ToolId == tool_id).SingleOrDefault();


                    if (pMTool != null)
                    {
                        pMTool.ToolName = toolName;

                        status = db.SaveChanges();
                    }
                    else
                    {
                        PMTool pMTool1 = new PMTool()
                        {

                            ToolId = tool_id,
                            ToolName = toolName

                        };

                        db.PMTools.Add(pMTool1);
                        status = db.SaveChanges();
                    }

                    return status;

                }

            }
            catch (Exception ex)
            {
                return 0;
            }



        }


        public static int insertOrUpdateAllFeatures(int feature_id, string featureName)
        {
            try
            {

                int status;

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    AllFeature allFeature = db.AllFeatures.Where(x => x.FeatureId == feature_id).SingleOrDefault();


                    if (allFeature != null)
                    {
                        allFeature.FeatureName = featureName;

                        status = db.SaveChanges();
                    }
                    else
                    {
                        AllFeature allFeature1 = new AllFeature()
                        {

                            FeatureId = feature_id,
                            FeatureName = featureName

                        };

                        db.AllFeatures.Add(allFeature1);
                        status = db.SaveChanges();
                    }

                    return status;

                }

            }
            catch (Exception ex)
            {
                return 0;
            }



        }

        public static int insertOrUpdateToolFeatureCategories(int featurecat_id, string featureCatName)
        {
            try
            {

                int status;

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    ToolFeatureCategory allFeature = db.ToolFeatureCategories.Where(x => x.FeatureCategoryId == featurecat_id).SingleOrDefault();


                    if (allFeature != null)
                    {
                        allFeature.FeatureCategoryName = featureCatName;

                        status = db.SaveChanges();
                    }
                    else
                    {
                        ToolFeatureCategory allFeature1 = new ToolFeatureCategory()
                        {

                            FeatureCategoryId = featurecat_id,
                            FeatureCategoryName = featureCatName

                        };

                        db.ToolFeatureCategories.Add(allFeature1);
                        status = db.SaveChanges();
                    }

                    return status;

                }

            }
            catch (Exception ex)
            {
                return 0;
            }


        }


        public static int insertOrUpdateToolFeatures(int id, int featureId, int FeatureCategoryId, int ToolId, string FeatureUrl, string FeatureStatus, string Date)
        {
            try
            {

                int status;

                using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
                {

                    ToolFeature toolFeatures = db.ToolFeatures.Where(x => x.Id == id).SingleOrDefault();


                    if (toolFeatures != null)
                    {
                        toolFeatures.FeatureId = featureId;
                        toolFeatures.FeatureCategoryId = FeatureCategoryId;
                        toolFeatures.ToolId = ToolId;
                        toolFeatures.FeatureUrl = FeatureUrl;
                        toolFeatures.FeatureStatus = FeatureStatus;
                        toolFeatures.Date = Date;


                        status = db.SaveChanges();
                    }
                    else
                    {
                      
                        ToolFeature toolFeature = new ToolFeature()
                        {
                            Id = id,
                            FeatureId = featureId,
                            FeatureCategoryId = FeatureCategoryId,
                            ToolId = ToolId,
                            FeatureUrl = FeatureUrl,
                            FeatureStatus = FeatureStatus,
                            Date = Date

                        };

                        db.ToolFeatures.Add(toolFeature);
                        status = db.SaveChanges();
                    }

                    return status;

                }

            }
            catch (Exception ex)
            {
                return 0;
            }


        }

        public static List<PMTool> getPMTools()
        {
            using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
            {

                return db.PMTools.ToList();

            }

        }

    }
}
