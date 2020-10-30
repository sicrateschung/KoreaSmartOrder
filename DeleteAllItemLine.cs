using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Xml;
using System.Net;
using System.Net.Http;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
namespace korea.octopus
{
    public static class DeleteAllItemLine
    {
        [FunctionName("DeleteAllItemLine")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            string location = req.Headers["Location"];

            string URL = Environment.GetEnvironmentVariable("BSSV_" + location.ToUpper() + "_URL");

            string Username = Environment.GetEnvironmentVariable("BSSVUsername");
            string Password = Environment.GetEnvironmentVariable("Password");

            string businessUnit = Environment.GetEnvironmentVariable("businessUnit");
            string company = Environment.GetEnvironmentVariable("company");

            int errorcount = 0;
            string error_message = "";

            string returndocumentCompany = "";
            string returndocumentNumber = "";
            string returndocumentTypeCode = "";

            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                HttpClient client = new HttpClient(clientHandler);

                HttpContent postcontent = new StringContent(requestBody, Encoding.UTF8, "text/xml");

                HttpResponseMessage response = await client.PostAsync(URL, postcontent);

                String responseString = await response.Content.ReadAsStringAsync();

                log.LogInformation("BODY:" + responseString);

                if (response.StatusCode == (HttpStatusCode)200)
                {

                    XmlSerializer XmlSerializer = new XmlSerializer(typeof(checkReturn.Envelope));
                    MemoryStream textstream = new MemoryStream(Encoding.UTF8.GetBytes(responseString));
                    checkReturn.Envelope returnEnvelope = (checkReturn.Envelope)XmlSerializer.Deserialize(textstream);
                    
                    if(returnEnvelope.Body.getSalesOrderResponse.header.Length>1){
                        return new BadRequestObjectResult("{\"status\":\"Failed\",\"resaon\":\""+"Order Found More Than One"+"\"}");
                    }
                    
                    for (int count = 0; count < returnEnvelope.Body.getSalesOrderResponse.header.Length; count++)
                    {
                        checkReturn.header temp = returnEnvelope.Body.getSalesOrderResponse.header[count];
                        Envelope return_xml = new Envelope();
                        EnvelopeHeader envelopeHeader = new EnvelopeHeader();
                        Security security = new Security();
                        SecurityUsernameToken securityUsernameToken = new SecurityUsernameToken();
                        securityUsernameToken.Username = Username;

                        SecurityUsernameTokenPassword tokenPassword = new SecurityUsernameTokenPassword();
                        tokenPassword.Type = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordText";
                        tokenPassword.Value = Password;
                        securityUsernameToken.Password = tokenPassword;

                        security.UsernameToken = securityUsernameToken;
                        envelopeHeader.Security = security;

                        EnvelopeBody envelopeBody = new EnvelopeBody();
                        processSalesOrder processSalesOrder = new processSalesOrder();
                        header header = new header();

                        header.businessUnit = businessUnit;
                        header.company = company;
                        List<headerDetail> ListofDetails = new List<headerDetail>();

                        for (int detailcount = 0; detailcount < temp.detail.Length; detailcount++)
                        {
                            headerDetail detail = new headerDetail();
                            headerDetailProcessing headerDetailProcessing = new headerDetailProcessing();
                            headerDetailProcessing.actionType = "D";

                            detail.documentLineNumber = decimal.ToInt32(temp.detail[detailcount].documentLineNumber);
                            detail.processing = headerDetailProcessing;
                            ListofDetails.Add(detail);
                        }
                        header.detail = ListofDetails.ToArray();

                        headerProcessing headerProcessing = new headerProcessing();
                        headerProcessing.actionType = "C";
                        headerProcessing.processingVersion = "SA";

                        header.processing = headerProcessing;
                        headerSalesOrderKey headerSalesOrderKey = new headerSalesOrderKey();
                        headerSalesOrderKey.documentCompany = temp.salesOrderKey.documentCompany;
                        headerSalesOrderKey.documentNumber = temp.salesOrderKey.documentNumber;
                        headerSalesOrderKey.documentTypeCode = temp.salesOrderKey.documentTypeCode;
                        header.salesOrderKey = headerSalesOrderKey;

                        if(count==0){
                            returndocumentCompany = temp.salesOrderKey.documentCompany;
                            returndocumentNumber = temp.salesOrderKey.documentNumber;
                            returndocumentTypeCode = temp.salesOrderKey.documentTypeCode;
                        }

                        headerShipTo headerShipTo = new headerShipTo();
                        headerShipToCustomer headerShipToCustomer = new headerShipToCustomer();
                        headerShipToCustomer.entityId = temp.shipTo.shipTo.entityId;
                        headerShipTo.customer = headerShipToCustomer;
                        header.shipTo = headerShipTo;

                        headerSoldTo headerSoldTo = new headerSoldTo();
                        headerSoldToCustomer headerSoldToCustomer = new headerSoldToCustomer();
                        headerSoldToCustomer.entityId = temp.soldTo.entityId;
                        headerSoldTo.customer = headerSoldToCustomer;
                        header.soldTo = headerSoldTo;

                        processSalesOrder.header = header;
                        envelopeBody.processSalesOrder = processSalesOrder;
                        return_xml.Header = envelopeHeader;
                        return_xml.Body = envelopeBody;
                        // BSSV Body 
                        System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(return_xml.GetType());

                        string return_string = "";

                        using (var stringwriter = new System.IO.StringWriter())
                        {
                            x.Serialize(stringwriter, return_xml);
                            return_string = stringwriter.ToString();
                        }
                        return_string = return_string.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");
                        log.LogInformation(return_string);

                        try
                        {
                            HttpClientHandler CancelclientHandler = new HttpClientHandler();
                            CancelclientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                            HttpClient Cancelclient = new HttpClient(CancelclientHandler);

                            HttpContent Cancelpostcontent = new StringContent(return_string, Encoding.UTF8, "text/xml");

                            HttpResponseMessage Cancelresponse = await client.PostAsync(URL, Cancelpostcontent);

                            //String CancelresponseString = await response.Content.ReadAsStringAsync();

                            if (Cancelresponse.StatusCode != (HttpStatusCode)200)
                            {
                                errorcount++;
                                error_message = "Delete Failed";
                            }
                        }
                        catch (Exception e)
                        {
                            errorcount++;
                            error_message = "Netwrok/XML Error:" + e.ToString();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                errorcount++;
                error_message = e.ToString();
            }

            if(returndocumentCompany==""){
                errorcount++;
                error_message = "No retrun Document Number Found";
            }

            if (errorcount == 0)
            {
                return new OkObjectResult("{\"status\":\"Success\","+
                                            "\"documentCompany\":\""+returndocumentCompany+"\","+
                                            "\"documentNumber\":\""+returndocumentNumber+"\","+
                                            "\"documentTypeCode\":\""+returndocumentTypeCode+"\"}"
                );
            }
            else
            {
                return new BadRequestObjectResult("{\"status\":\"Failed\",\"resaon\":\""+error_message+"\"}");
            }

        }
    }
}