using Newtonsoft.Json;
using PMToolMapper;
using PTM.DBAccess.DBModel;
using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PTM.BusinessLogic.Services
{
    public class ApiData
    {


        public async Task getPMToolData()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(ApiUrl.apiUrl);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.GetAsync(ApiUrl.apiUrl + "getTools").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var dataObjects = await response.Content.ReadAsStringAsync();  

                    List<PMtoolModel> PMTool_List = JsonConvert.DeserializeObject<List<PMtoolModel>>(dataObjects);

                    foreach (var d in PMTool_List)
                    {
                        PMTDataAccess.insertOrUpdateTool(d.ToolId, d.ToolName);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

                // Make any other calls using HttpClient here.

                // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
                client.Dispose();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }


        }



        public async Task getAllFeaturesData()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(ApiUrl.apiUrl);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.GetAsync(ApiUrl.apiUrl + "getAllFeatures").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var dataObjects = await response.Content.ReadAsStringAsync();  

                    List<AllFeaturesModel> allFeaturesModels = JsonConvert.DeserializeObject<List<AllFeaturesModel>>(dataObjects);

                    foreach (var d in allFeaturesModels)
                    {
                        PMTDataAccess.insertOrUpdateAllFeatures(d.FeatureId, d.FeatureName);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

                // Make any other calls using HttpClient here.

                // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
                client.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }


        }


        public async Task getAllFeaturesCatData()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(ApiUrl.apiUrl);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.GetAsync(ApiUrl.apiUrl + "getToolFeatureCategories").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var dataObjects = await response.Content.ReadAsStringAsync();  

                    List<ToolFeatureCategoriesModel> allFeaturesCatModels = JsonConvert.DeserializeObject<List<ToolFeatureCategoriesModel>>(dataObjects);

                    foreach (var d in allFeaturesCatModels)
                    {
                        PMTDataAccess.insertOrUpdateToolFeatureCategories(d.FeatureCategoryId, d.FeatureCategoryName);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

                // Make any other calls using HttpClient here.

                // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
                client.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }


        }


        public async Task getToolFeaturesData()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(ApiUrl.apiUrl);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.GetAsync(ApiUrl.apiUrl + "getToolFeatures").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var dataObjects = await response.Content.ReadAsStringAsync();

                    List<ToolFeaturesModel> toofeatures = JsonConvert.DeserializeObject<List<ToolFeaturesModel>>(dataObjects);

                    foreach (var d in toofeatures)
                    {
                        PMTDataAccess.insertOrUpdateToolFeatures(d.Id, d.FeatureId, d.FeatureCategoryId, d.ToolId, d.FeatureUrl, d.FeatureStatus, d.Date);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

                // Make any other calls using HttpClient here.

                // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
                client.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }


        }

    }
}
