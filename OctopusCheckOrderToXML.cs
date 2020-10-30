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
    public static class OctopusCheckOrderToXML
    {
        [FunctionName("OctopusCheckOrderToXML")]
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
            getSalesOrder getSalesOrder = new getSalesOrder();
            header header = new header();

            header.businessUnit = businessUnit;
            header.company = company;
            header.customerPO = order.FrontExternalId;

            headerSalesOrderKey headerSalesOrderKey = new headerSalesOrderKey();

            headerSalesOrderKey.documentCompany = company;
            headerSalesOrderKey.documentTypeCode = "SA";

            header.salesOrderKey = headerSalesOrderKey;


            headerSoldTo headerSoldTo = new headerSoldTo();
            headerSoldTo.entityId = "8126052";
            //order.Customer.ConsumerFrontExternalId;

            header.soldTo = headerSoldTo;

            headerShipTo headerShipTo = new headerShipTo();
            headerShipTo.entityId = "8126052";
            //order.Customer.ConsumerFrontExternalId;

            header.shipTo = headerShipTo;

            getSalesOrder.header = header;
            envelopeBody.getSalesOrder = getSalesOrder;

            return_xml.Header = envelopeHeader;
            return_xml.Body = envelopeBody;
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(return_xml.GetType());


            string return_string = "";

            using (var stringwriter = new System.IO.StringWriter())
            {
                x.Serialize(stringwriter, return_xml);
                return_string = stringwriter.ToString();
            }
            return_string = return_string.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "");

            return new OkObjectResult(return_string);
        }
    }
}
