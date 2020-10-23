using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace korea.octopus
{
    public static class OctopusOrderToXML
    {
        [FunctionName("OctopusOrderToXML")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            OctopusOrder order = JsonConvert.DeserializeObject<OctopusOrder>(requestBody);
            
            //log.LogInformation(requestBody);

            string Username = Environment.GetEnvironmentVariable("BSSVUsername");
            string Password = Environment.GetEnvironmentVariable("Password");

            string businessUnit = Environment.GetEnvironmentVariable("businessUnit");
            string company = Environment.GetEnvironmentVariable("company");

            //log.LogInformation("USER_NAME:"+Username);
            Envelope return_xml = new Envelope();
            
            // BSSV Account Password
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

            // BSSV Body 
            EnvelopeBody envelopeBody = new EnvelopeBody();
            processSalesOrder processSalesOrder = new processSalesOrder();
            header header = new header();
            header.company = company;

            headerProcessing headerprocessing = new headerProcessing();
            headerprocessing.actionType = "A";
            headerprocessing.processingVersion = "SA";

            header.processing = headerprocessing;

            header.businessUnit = businessUnit;
            header.customerPO = order.Customer.ConsumerFrontExternalId;
            header.dateOrdered = order.CreatedDate.ToString("yyyy-MM-dd");
            header.dateRequested = order.CreatedDate.ToString("yyyy-MM-dd");


            header.orderedBy = "OCTOPUS";

            headerBilling headerBilling = new headerBilling();
            headerBilling.deliveryInstruction1 = "Delivery Instruction 1";
            headerBilling.deliveryInstruction2 = "Delivery Instruction 2";
            header.billing = headerBilling;

            headerSoldTo headerSoldTo = new headerSoldTo();
            headerSoldToCustomer headerSoldToCustomer = new headerSoldToCustomer();
            headerSoldToCustomer.entityId = "8126052";
            //order.Customer.ConsumerFrontExternalId;

            headerSoldTo.customer = headerSoldToCustomer;
            header.soldTo = headerSoldTo;

            headerShipTo headerShipTo = new headerShipTo();
            headerShipToCustomer headerShipToCustomer = new headerShipToCustomer();
            headerShipToCustomer.entityId = "8126052";
            //order.Customer.ConsumerFrontExternalId;
            
            headerShipTo.customer = headerShipToCustomer;
            headerShipTo.addressLine1 =  order.BillingAddress.Street1;
            headerShipTo.addressLine2 =  order.BillingAddress.Street2;
            headerShipTo.addressLine3 =  order.BillingAddress.Street3;
            headerShipTo.addressLine4 =  order.BillingAddress.State;
            header.shipTo = headerShipTo;   

            headerDetail[] details = new headerDetail[order.Details.Length];
            
            for(int count = 0; count < order.Details.Length;count++){
                headerDetail headerDetail = new headerDetail();
                headerDetail.documentLineNumber = count+1;
                headerDetailProcessing headerDetailProcessing = new headerDetailProcessing();
                headerDetailProcessing.actionType = "A";
                

                headerDetail.processing = headerDetailProcessing;
                headerDetailProduct productdetail = new headerDetailProduct();

                headerDetailProductItem headerDetailProductItem = new headerDetailProductItem();
                headerDetailProductItem.itemProduct = "1BA120551R2";
                //headerDetailProductItem.itemProduct = order.Details[count].Product.BackExternalId;
                productdetail.item = headerDetailProductItem;
                headerDetail.product = productdetail;
                headerDetail.quantityOrdered = order.Details[count].Quantity;
                details[count] = headerDetail;

            }

            header.detail = details;
            processSalesOrder.header = header;
            envelopeBody.processSalesOrder = processSalesOrder;

            return_xml.Header = envelopeHeader;
            return_xml.Body = envelopeBody;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(return_xml.GetType());
            

            string return_string = "";
            
            using(var stringwriter = new System.IO.StringWriter())
            { 
                x.Serialize(stringwriter, return_xml);
                return_string = stringwriter.ToString();
            }
            return_string = return_string.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>","");

            return new OkObjectResult(return_string);
        }
    }
}
