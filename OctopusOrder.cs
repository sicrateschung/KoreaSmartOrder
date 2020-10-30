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
        public object[] Refunds { get; set; }
        public Customfield[] CustomFields { get; set; }
        public Detail[] Details { get; set; }
        public Customer Customer { get; set; }
        public Shippingaddress ShippingAddress { get; set; }
        public Billingaddress BillingAddress { get; set; }
        public object[] Shipments { get; set; }
        public Payment Payment { get; set; }
        public string Id { get; set; }
        public string PlatformId { get; set; }
        public string FrontExternalId { get; set; }
        public object BackExternalId { get; set; }
        public object BackInvoiceId { get; set; }
        public object InvoiceDate { get; set; }
        public object TransactionId { get; set; }
        public object PaymentMethod { get; set; }
        public object PaymentStatus { get; set; }
        public decimal ShippingRate { get; set; }
        public decimal ShippingRateWithoutVAT { get; set; }
        public object FreeShipping { get; set; }
        public object ShippingMethod { get; set; }
        public object TrackingNumber { get; set; }
        public object TrackingTitle { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public decimal VATRate { get; set; }
        public decimal TotalAmountWithVAT { get; set; }
        public decimal TotalDiscountedAmountWithVAT { get; set; }
        public decimal TotalAmountWithoutVAT { get; set; }
        public decimal TotalDiscountedAmountWithoutVAT { get; set; }
        public object DiscountAmountWithVAT { get; set; }
        public object DiscountAmountWithoutVAT { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public object CurrencyCode { get; set; }
        public object PurchaseDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class Customer
    {
        public string ConsumerFrontExternalId { get; set; }
        public object ConsumerBackExternalId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
    }

    public class Shippingaddress
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class Billingaddress
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }

    public class Payment
    {
        public object TransactionId { get; set; }
        public object PaymentMethod { get; set; }
        public object PaymentStatus { get; set; }
    }

    public class Customfield
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }
    }

    public class Detail
    {
        public object[] CustomFields { get; set; }
        public Product Product { get; set; }
        public int Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscounted { get; set; }
        public bool Active { get; set; }
    }

    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BackExternalId { get; set; }
        public string Sku { get; set; }
        public string PlatformId { get; set; }
        public bool Active { get; set; }
        public string PimId { get; set; }
    }
}
