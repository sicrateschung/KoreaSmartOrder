using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace korea.octopus
{
    public static class PostToBSSV
    {
        [FunctionName("PostToBSSV")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            string location = req.Headers["Location"];

            string URL = Environment.GetEnvironmentVariable("BSSV_" + location.ToUpper() + "_URL");

            try{
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                HttpClient client = new HttpClient(clientHandler);
                            
                HttpContent postcontent = new StringContent(requestBody,Encoding.UTF8,"text/xml");

                HttpResponseMessage response = await client.PostAsync(URL,postcontent);

                String responseString = await response.Content.ReadAsStringAsync();
                
                log.LogInformation("BODY:"+ responseString);


                if(response.StatusCode == (HttpStatusCode)200){
                    return new OkObjectResult(
                    "{ Status:\"successed\","+
                    "Reason:\"" + responseString+ "\""+
                    "}");
                }
                else{
                    return new BadRequestObjectResult(
                        "{ Status:\"Failed\", " + 
                        "Reason:\"" + responseString+ "\""+
                        "requestBody:\"" + requestBody + "\", " +
                        "url:\"" + URL + "\"" +
                        "}"
                        );
                }
            }
            catch(Exception e){
                log.LogInformation(e.ToString());
                return new BadRequestObjectResult(
                    "{ Status:\"Failed\", " + 
                    "Reason:\"" + e.ToString()+ "\", "+
                    "requestBody:\"" + requestBody + "\", " +
                    "url:\"" + URL + "\"" +
                    "}");
            }
        }
    }
}
