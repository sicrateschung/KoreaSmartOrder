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
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeHeader headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeHeader
    {

        private Security securityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]
        public Security Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "", IsNullable = false)]
    public partial class Security
    {

        private SecurityUsernameToken usernameTokenField;

        private byte mustUnderstandField;

        /// <remarks/>
        public SecurityUsernameToken UsernameToken
        {
            get
            {
                return this.usernameTokenField;
            }
            set
            {
                this.usernameTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public byte mustUnderstand
        {
            get
            {
                return this.mustUnderstandField;
            }
            set
            {
                this.mustUnderstandField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class SecurityUsernameToken
    {

        private string usernameField;

        private SecurityUsernameTokenPassword passwordField;

        /// <remarks/>
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public SecurityUsernameTokenPassword Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class SecurityUsernameTokenPassword
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private processSalesOrder processSalesOrderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://oracle.e1.bssv.JP420000/")]
        public processSalesOrder processSalesOrder
        {
            get
            {
                return this.processSalesOrderField;
            }
            set
            {
                this.processSalesOrderField = value;
            }
        }

        private getSalesOrder getSalesOrderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://oracle.e1.bssv.JP420000/")]
        public getSalesOrder getSalesOrder
        {
            get
            {
                return this.getSalesOrderField;
            }
            set
            {
                this.getSalesOrderField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://oracle.e1.bssv.JP420000/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://oracle.e1.bssv.JP420000/", IsNullable = false)]
    public partial class getSalesOrder
    {

        private header headerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public header header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://oracle.e1.bssv.JP420000/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://oracle.e1.bssv.JP420000/", IsNullable = false)]
    public partial class processSalesOrder
    {

        private header headerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public header header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class header
    {

        private headerProcessing processingField;

        private string businessUnitField;

        private string companyField;

        private string customerPOField;

        private string dateOrderedField;

        private string dateRequestedField;

        private string orderedByField;

        private headerBilling billingField;

        private headerShipTo shipToField;

        private headerSoldTo soldToField;

        private headerDetail[] detailField;

        private headerSalesOrderKey salesOrderKeyField;

        /// <remarks/>
        public headerProcessing processing
        {
            get
            {
                return this.processingField;
            }
            set
            {
                this.processingField = value;
            }
        }

        /// <remarks/>
        public string businessUnit
        {
            get
            {
                return this.businessUnitField;
            }
            set
            {
                this.businessUnitField = value;
            }
        }

        /// <remarks/>
        public string company
        {
            get
            {
                return this.companyField;
            }
            set
            {
                this.companyField = value;
            }
        }

        /// <remarks/>
        public string customerPO
        {
            get
            {
                return this.customerPOField;
            }
            set
            {
                this.customerPOField = value;
            }
        }

        public headerSalesOrderKey salesOrderKey
        {
            get
            {
                return this.salesOrderKeyField;
            }
            set
            {
                this.salesOrderKeyField = value;
            }
        }

        /// <remarks/>
        public string dateOrdered
        {
            get
            {
                return this.dateOrderedField;
            }
            set
            {
                this.dateOrderedField = value;
            }
        }

        /// <remarks/>
        public string dateRequested
        {
            get
            {
                return this.dateRequestedField;
            }
            set
            {
                this.dateRequestedField = value;
            }
        }

        /// <remarks/>
        public string orderedBy
        {
            get
            {
                return this.orderedByField;
            }
            set
            {
                this.orderedByField = value;
            }
        }

        /// <remarks/>
        public headerBilling billing
        {
            get
            {
                return this.billingField;
            }
            set
            {
                this.billingField = value;
            }
        }


        /// <remarks/>
        public headerShipTo shipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public headerSoldTo soldTo
        {
            get
            {
                return this.soldToField;
            }
            set
            {
                this.soldToField = value;
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detail")]
        public headerDetail[] detail
        {
            get
            {
                return this.detailField;
            }
            set
            {
                this.detailField = value;
            }
        }
    }

                /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class headerSalesOrderKey
        {

            private string documentCompanyField;

            private string documentNumberField;
            
            private string documentTypeCodeField;

            /// <remarks/>
            public string documentCompany
            {
                get
                {
                    return this.documentCompanyField;
                }
                set
                {
                    this.documentCompanyField = value;
                }
            }

            public string documentNumber
            {
                get
                {
                    return this.documentNumberField;
                }
                set
                {
                    this.documentNumberField = value;
                }
            }


            /// <remarks/>
            public string documentTypeCode
            {
                get
                {
                    return this.documentTypeCodeField;
                }
                set
                {
                    this.documentTypeCodeField = value;
                }
            }
        }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerProcessing
    {

        private string actionTypeField;

        private string processingVersionField;

        /// <remarks/>
        public string actionType
        {
            get
            {
                return this.actionTypeField;
            }
            set
            {
                this.actionTypeField = value;
            }
        }

        /// <remarks/>
        public string processingVersion
        {
            get
            {
                return this.processingVersionField;
            }
            set
            {
                this.processingVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerBilling
    {

        private string deliveryInstruction1Field;

        private string deliveryInstruction2Field;

        /// <remarks/>
        public string deliveryInstruction1
        {
            get
            {
                return this.deliveryInstruction1Field;
            }
            set
            {
                this.deliveryInstruction1Field = value;
            }
        }

        /// <remarks/>
        public string deliveryInstruction2
        {
            get
            {
                return this.deliveryInstruction2Field;
            }
            set
            {
                this.deliveryInstruction2Field = value;
            }
        }
    }

    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerShipTo
    {
        private string addressLine1Field;
        private string addressLine2Field;
        private string addressLine3Field;
        private string addressLine4Field;
        private string entityIdField;

        private headerShipToCustomer customerField;

        private string mailingNameField;

                /// <remarks/>
        public string addressLine1
        {
            get
            {
                return this.addressLine1Field;
            }
            set
            {
                this.addressLine1Field = value;
            }
        }

        public string addressLine2
        {
            get
            {
                return this.addressLine2Field;
            }
            set
            {
                this.addressLine2Field = value;
            }
        }


        public string addressLine3
        {
            get
            {
                return this.addressLine3Field;
            }
            set
            {
                this.addressLine3Field = value;
            }
        }


        /// <remarks/>
        public string addressLine4
        {
            get
            {
                return this.addressLine4Field;
            }
            set
            {
                this.addressLine4Field = value;
            }
        }

        public string entityId
        {
            get
            {
                return this.entityIdField;
            }
            set
            {
                this.entityIdField = value;
            }
        }
        
        /// <remarks/>
        public headerShipToCustomer customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public string mailingName
        {
            get
            {
                return this.mailingNameField;
            }
            set
            {
                this.mailingNameField = value;
            }
        }
    }


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerShipToCustomer
    {

        private string entityIdField;

        /// <remarks/>
        public string entityId
        {
            get
            {
                return this.entityIdField;
            }
            set
            {
                this.entityIdField = value;
            }
        }
    }


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerSoldTo
    {

        private headerSoldToCustomer customerField;

        private string entityIdField;

        /// <remarks/>
        public headerSoldToCustomer customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        public string entityId
        {
            get
            {
                return this.entityIdField;
            }
            set
            {
                this.entityIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerSoldToCustomer
    {

        private string entityIdField;

        /// <remarks/>
        public string entityId
        {
            get
            {
                return this.entityIdField;
            }
            set
            {
                this.entityIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetail
    {

        private int documentLineNumberField;

        private headerDetailProcessing processingField;

        private headerDetailProduct productField;

        private int quantityOrderedField;

        private headerDetailUserReservedData userReservedDataField;

        /// <remarks/>
        public int documentLineNumber
        {
            get
            {
                return this.documentLineNumberField;
            }
            set
            {
                this.documentLineNumberField = value;
            }
        }

        /// <remarks/>
        public headerDetailProcessing processing
        {
            get
            {
                return this.processingField;
            }
            set
            {
                this.processingField = value;
            }
        }

        /// <remarks/>
        public headerDetailProduct product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        public int quantityOrdered
        {
            get
            {
                return this.quantityOrderedField;
            }
            set
            {
                this.quantityOrderedField = value;
            }
        }

        /// <remarks/>
        public headerDetailUserReservedData userReservedData
        {
            get
            {
                return this.userReservedDataField;
            }
            set
            {
                this.userReservedDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailProcessing
    {

        private string actionTypeField;

        /// <remarks/>
        public string actionType
        {
            get
            {
                return this.actionTypeField;
            }
            set
            {
                this.actionTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailProduct
    {

        private headerDetailProductItem itemField;

        /// <remarks/>
        public headerDetailProductItem item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailProductItem
    {

        private string itemProductField;

        /// <remarks/>
        public string itemProduct
        {
            get
            {
                return this.itemProductField;
            }
            set
            {
                this.itemProductField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailUserReservedData
    {

        private string userReservedReferenceField;

        /// <remarks/>
        public string userReservedReference
        {
            get
            {
                return this.userReservedReferenceField;
            }
            set
            {
                this.userReservedReferenceField = value;
            }
        }
    }
}
