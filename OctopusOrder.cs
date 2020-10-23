using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace korea.octopus
{
    public class OctopusOrder
    {
        public string Id { get; set; }
        public string FrontExternalId { get; set; }
        public float TotalAmountWithVAT { get; set; }
        public float TotalAmountWithoutVAT { get; set; }
        public float TotalDiscountedAmountWithVAT { get; set; }
        public float TotalDiscountedAmountWithoutVAT { get; set; }
        public float ShippingRate { get; set; }
        public float ShippingRateWithoutVAT { get; set; }
        public float VATRate { get; set; }
        public string PlatformId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Customer Customer { get; set; }
        public Billingaddress BillingAddress { get; set; }
        public Shippingaddress ShippingAddress { get; set; }
        public Detail[] Details { get; set; }
        public Customfield[] CustomFields { get; set; }
    }

    public class Customer
    {
        public string ConsumerFrontExternalId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
    }

    public class Billingaddress
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class Shippingaddress
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class Detail
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float UnitPriceDiscounted { get; set; }
        public Product Product { get; set; }
        public object[] CustomFields { get; set; }
    }

    public class Product
    {
        public string Id { get; set; }
        public string PlatformId { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string BackExternalId { get; set; }
        public string PimId { get; set; }
    }

    public class Customfield
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
