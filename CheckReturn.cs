using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkReturn
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private object headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public object Header
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
    public partial class EnvelopeBody
    {

        private getSalesOrderResponse getSalesOrderResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://oracle.e1.bssv.JP420000/")]
        public getSalesOrderResponse getSalesOrderResponse
        {
            get
            {
                return this.getSalesOrderResponseField;
            }
            set
            {
                this.getSalesOrderResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://oracle.e1.bssv.JP420000/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://oracle.e1.bssv.JP420000/", IsNullable = false)]
    public partial class getSalesOrderResponse
    {

        private object e1MessageListField;

        private header[] headerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public object e1MessageList
        {
            get
            {
                return this.e1MessageListField;
            }
            set
            {
                this.e1MessageListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("header", Namespace = "")]
        public header[] header
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

        private byte rMAIdField;

        private object rMATypeField;

        private string adjustmentScheduleCodeField;

        private uint amountTotalOrderDomesticField;

        private byte amountTotalOrderForeignField;

        private string businessUnitField;

        private byte companyField;

        private string currencyCodeFromField;

        private string currencyModeCodeField;

        private uint customerPOField;

        private string customerPriceGroupCodeField;

        private System.DateTime datePromisedShipField;

        private System.DateTime dateRequestedField;

        private System.DateTime dateScheduledPickField;

        private System.DateTime dateTransactionField;

        private headerDeliverTo deliverToField;

        private string deliveryInstruction1Field;

        private string deliveryInstruction2Field;

        private headerDetail[] detailField;

        private byte entityIdCarrierField;

        private headerForwardedTo forwardedToField;

        private object freightHandlingCodeField;

        private object holdOrderCodeField;

        private headerInvoicedTo invoicedToField;

        private object modeOfTransportField;

        private string orderTakenByField;

        private string orderedByField;

        private headerOriginalOrder originalOrderField;

        private headerPaidBy paidByField;

        private string paymentInstrumentCodeField;

        private string paymentTermsCodeField;

        private decimal percentDiscountTradeField;

        private string printMessageCodeField;

        private float rateExchangeOverrideField;

        private object reasonCodeField;

        private object routeCodeField;

        private headerSalesOrderKey salesOrderKeyField;

        private headerShipTo shipToField;

        private headerSoldTo soldToField;

        private object stopCodeField;

        private string taxExplanationCodeField;

        private string taxRateAreaCodeField;

        private headerUserReservedData userReservedDataField;

        private object zoneNumberField;

        /// <remarks/>
        public byte RMAId
        {
            get
            {
                return this.rMAIdField;
            }
            set
            {
                this.rMAIdField = value;
            }
        }

        /// <remarks/>
        public object RMAType
        {
            get
            {
                return this.rMATypeField;
            }
            set
            {
                this.rMATypeField = value;
            }
        }

        /// <remarks/>
        public string adjustmentScheduleCode
        {
            get
            {
                return this.adjustmentScheduleCodeField;
            }
            set
            {
                this.adjustmentScheduleCodeField = value;
            }
        }

        /// <remarks/>
        public uint amountTotalOrderDomestic
        {
            get
            {
                return this.amountTotalOrderDomesticField;
            }
            set
            {
                this.amountTotalOrderDomesticField = value;
            }
        }

        /// <remarks/>
        public byte amountTotalOrderForeign
        {
            get
            {
                return this.amountTotalOrderForeignField;
            }
            set
            {
                this.amountTotalOrderForeignField = value;
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
        public byte company
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
        public string currencyCodeFrom
        {
            get
            {
                return this.currencyCodeFromField;
            }
            set
            {
                this.currencyCodeFromField = value;
            }
        }

        /// <remarks/>
        public string currencyModeCode
        {
            get
            {
                return this.currencyModeCodeField;
            }
            set
            {
                this.currencyModeCodeField = value;
            }
        }

        /// <remarks/>
        public uint customerPO
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

        /// <remarks/>
        public string customerPriceGroupCode
        {
            get
            {
                return this.customerPriceGroupCodeField;
            }
            set
            {
                this.customerPriceGroupCodeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datePromisedShip
        {
            get
            {
                return this.datePromisedShipField;
            }
            set
            {
                this.datePromisedShipField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateRequested
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
        public System.DateTime dateScheduledPick
        {
            get
            {
                return this.dateScheduledPickField;
            }
            set
            {
                this.dateScheduledPickField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateTransaction
        {
            get
            {
                return this.dateTransactionField;
            }
            set
            {
                this.dateTransactionField = value;
            }
        }

        /// <remarks/>
        public headerDeliverTo deliverTo
        {
            get
            {
                return this.deliverToField;
            }
            set
            {
                this.deliverToField = value;
            }
        }

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

        /// <remarks/>
        public byte entityIdCarrier
        {
            get
            {
                return this.entityIdCarrierField;
            }
            set
            {
                this.entityIdCarrierField = value;
            }
        }

        /// <remarks/>
        public headerForwardedTo forwardedTo
        {
            get
            {
                return this.forwardedToField;
            }
            set
            {
                this.forwardedToField = value;
            }
        }

        /// <remarks/>
        public object freightHandlingCode
        {
            get
            {
                return this.freightHandlingCodeField;
            }
            set
            {
                this.freightHandlingCodeField = value;
            }
        }

        /// <remarks/>
        public object holdOrderCode
        {
            get
            {
                return this.holdOrderCodeField;
            }
            set
            {
                this.holdOrderCodeField = value;
            }
        }

        /// <remarks/>
        public headerInvoicedTo invoicedTo
        {
            get
            {
                return this.invoicedToField;
            }
            set
            {
                this.invoicedToField = value;
            }
        }

        /// <remarks/>
        public object modeOfTransport
        {
            get
            {
                return this.modeOfTransportField;
            }
            set
            {
                this.modeOfTransportField = value;
            }
        }

        /// <remarks/>
        public string orderTakenBy
        {
            get
            {
                return this.orderTakenByField;
            }
            set
            {
                this.orderTakenByField = value;
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
        public headerOriginalOrder originalOrder
        {
            get
            {
                return this.originalOrderField;
            }
            set
            {
                this.originalOrderField = value;
            }
        }

        /// <remarks/>
        public headerPaidBy paidBy
        {
            get
            {
                return this.paidByField;
            }
            set
            {
                this.paidByField = value;
            }
        }

        /// <remarks/>
        public string paymentInstrumentCode
        {
            get
            {
                return this.paymentInstrumentCodeField;
            }
            set
            {
                this.paymentInstrumentCodeField = value;
            }
        }

        /// <remarks/>
        public string paymentTermsCode
        {
            get
            {
                return this.paymentTermsCodeField;
            }
            set
            {
                this.paymentTermsCodeField = value;
            }
        }

        /// <remarks/>
        public decimal percentDiscountTrade
        {
            get
            {
                return this.percentDiscountTradeField;
            }
            set
            {
                this.percentDiscountTradeField = value;
            }
        }

        /// <remarks/>
        public string printMessageCode
        {
            get
            {
                return this.printMessageCodeField;
            }
            set
            {
                this.printMessageCodeField = value;
            }
        }

        /// <remarks/>
        public float rateExchangeOverride
        {
            get
            {
                return this.rateExchangeOverrideField;
            }
            set
            {
                this.rateExchangeOverrideField = value;
            }
        }

        /// <remarks/>
        public object reasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
            }
        }

        /// <remarks/>
        public object routeCode
        {
            get
            {
                return this.routeCodeField;
            }
            set
            {
                this.routeCodeField = value;
            }
        }

        /// <remarks/>
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
        public object stopCode
        {
            get
            {
                return this.stopCodeField;
            }
            set
            {
                this.stopCodeField = value;
            }
        }

        /// <remarks/>
        public string taxExplanationCode
        {
            get
            {
                return this.taxExplanationCodeField;
            }
            set
            {
                this.taxExplanationCodeField = value;
            }
        }

        /// <remarks/>
        public string taxRateAreaCode
        {
            get
            {
                return this.taxRateAreaCodeField;
            }
            set
            {
                this.taxRateAreaCodeField = value;
            }
        }

        /// <remarks/>
        public headerUserReservedData userReservedData
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

        /// <remarks/>
        public object zoneNumber
        {
            get
            {
                return this.zoneNumberField;
            }
            set
            {
                this.zoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDeliverTo
    {

        private byte entityIdField;

        /// <remarks/>
        public byte entityId
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

        private object agreementIdField;

        private byte agreementSupplementField;

        private string businessUnitField;

        private headerDetailCategoryCodesPurchasing categoryCodesPurchasingField;

        private headerDetailCategoryCodesSales categoryCodesSalesField;

        private byte companyField;

        private uint costExtendedDomesticField;

        private byte costExtendedForeignField;

        private decimal costUnitPurchasingDomesticField;

        private decimal costUnitPurchasingForeignField;

        private string currencyCodeFromField;

        private uint customerPOField;

        private System.DateTime dateCancelField;

        private bool dateCancelFieldSpecified;

        private System.DateTime dateOrderedField;

        private System.DateTime datePromisedDeliveryField;

        private System.DateTime datePromisedOriginalField;

        private System.DateTime datePromisedShipField;

        private System.DateTime dateRequestedField;

        private System.DateTime dateScheduledPickField;

        private headerDetailDeliverTo deliverToField;

        private byte deliveryIdField;

        private headerDetailDocument documentField;

        private decimal documentLineNumberField;

        private object dutyStatusCodeField;

        private object endUseCodeField;

        private byte entityIdSupplierField;

        private headerDetailLineBilling lineBillingField;

        private object lineOfBusinessCodeField;

        private string lineTypeCodeField;

        private headerDetailOriginalOrder originalOrderField;

        private headerDetailParent parentField;

        private byte pickSlipIdField;

        private headerDetailProduct productField;

        private byte quantityBackOrderedField;

        private byte quantityCanceledField;

        private byte quantityOrderedField;

        private byte quantityShippableField;

        private float rateExchangeOverrideField;

        private object referenceField;

        private headerDetailRelatedOrder relatedOrderField;

        private headerDetailShipTo shipToField;

        private byte shipmentIdField;

        private headerDetailSoldTo soldToField;

        private ushort statusCodeLastField;

        private ushort statusCodeNextField;

        private byte timePromisedDeliveryField;

        private byte timePromisedOriginalField;

        private byte timePromisedShipField;

        private byte timeRequestedField;

        private byte timeScheduledPickField;

        private string unitOfMeasureCodeTransactionField;

        private headerDetailUserReservedData userReservedDataField;

        /// <remarks/>
        public object agreementId
        {
            get
            {
                return this.agreementIdField;
            }
            set
            {
                this.agreementIdField = value;
            }
        }

        /// <remarks/>
        public byte agreementSupplement
        {
            get
            {
                return this.agreementSupplementField;
            }
            set
            {
                this.agreementSupplementField = value;
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
        public headerDetailCategoryCodesPurchasing categoryCodesPurchasing
        {
            get
            {
                return this.categoryCodesPurchasingField;
            }
            set
            {
                this.categoryCodesPurchasingField = value;
            }
        }

        /// <remarks/>
        public headerDetailCategoryCodesSales categoryCodesSales
        {
            get
            {
                return this.categoryCodesSalesField;
            }
            set
            {
                this.categoryCodesSalesField = value;
            }
        }

        /// <remarks/>
        public byte company
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
        public uint costExtendedDomestic
        {
            get
            {
                return this.costExtendedDomesticField;
            }
            set
            {
                this.costExtendedDomesticField = value;
            }
        }

        /// <remarks/>
        public byte costExtendedForeign
        {
            get
            {
                return this.costExtendedForeignField;
            }
            set
            {
                this.costExtendedForeignField = value;
            }
        }

        /// <remarks/>
        public decimal costUnitPurchasingDomestic
        {
            get
            {
                return this.costUnitPurchasingDomesticField;
            }
            set
            {
                this.costUnitPurchasingDomesticField = value;
            }
        }

        /// <remarks/>
        public decimal costUnitPurchasingForeign
        {
            get
            {
                return this.costUnitPurchasingForeignField;
            }
            set
            {
                this.costUnitPurchasingForeignField = value;
            }
        }

        /// <remarks/>
        public string currencyCodeFrom
        {
            get
            {
                return this.currencyCodeFromField;
            }
            set
            {
                this.currencyCodeFromField = value;
            }
        }

        /// <remarks/>
        public uint customerPO
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

        /// <remarks/>
        public System.DateTime dateCancel
        {
            get
            {
                return this.dateCancelField;
            }
            set
            {
                this.dateCancelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateCancelSpecified
        {
            get
            {
                return this.dateCancelFieldSpecified;
            }
            set
            {
                this.dateCancelFieldSpecified = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateOrdered
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
        public System.DateTime datePromisedDelivery
        {
            get
            {
                return this.datePromisedDeliveryField;
            }
            set
            {
                this.datePromisedDeliveryField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datePromisedOriginal
        {
            get
            {
                return this.datePromisedOriginalField;
            }
            set
            {
                this.datePromisedOriginalField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datePromisedShip
        {
            get
            {
                return this.datePromisedShipField;
            }
            set
            {
                this.datePromisedShipField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dateRequested
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
        public System.DateTime dateScheduledPick
        {
            get
            {
                return this.dateScheduledPickField;
            }
            set
            {
                this.dateScheduledPickField = value;
            }
        }

        /// <remarks/>
        public headerDetailDeliverTo deliverTo
        {
            get
            {
                return this.deliverToField;
            }
            set
            {
                this.deliverToField = value;
            }
        }

        /// <remarks/>
        public byte deliveryId
        {
            get
            {
                return this.deliveryIdField;
            }
            set
            {
                this.deliveryIdField = value;
            }
        }

        /// <remarks/>
        public headerDetailDocument document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }

        /// <remarks/>
        public decimal documentLineNumber
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
        public object dutyStatusCode
        {
            get
            {
                return this.dutyStatusCodeField;
            }
            set
            {
                this.dutyStatusCodeField = value;
            }
        }

        /// <remarks/>
        public object endUseCode
        {
            get
            {
                return this.endUseCodeField;
            }
            set
            {
                this.endUseCodeField = value;
            }
        }

        /// <remarks/>
        public byte entityIdSupplier
        {
            get
            {
                return this.entityIdSupplierField;
            }
            set
            {
                this.entityIdSupplierField = value;
            }
        }

        /// <remarks/>
        public headerDetailLineBilling lineBilling
        {
            get
            {
                return this.lineBillingField;
            }
            set
            {
                this.lineBillingField = value;
            }
        }

        /// <remarks/>
        public object lineOfBusinessCode
        {
            get
            {
                return this.lineOfBusinessCodeField;
            }
            set
            {
                this.lineOfBusinessCodeField = value;
            }
        }

        /// <remarks/>
        public string lineTypeCode
        {
            get
            {
                return this.lineTypeCodeField;
            }
            set
            {
                this.lineTypeCodeField = value;
            }
        }

        /// <remarks/>
        public headerDetailOriginalOrder originalOrder
        {
            get
            {
                return this.originalOrderField;
            }
            set
            {
                this.originalOrderField = value;
            }
        }

        /// <remarks/>
        public headerDetailParent parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }

        /// <remarks/>
        public byte pickSlipId
        {
            get
            {
                return this.pickSlipIdField;
            }
            set
            {
                this.pickSlipIdField = value;
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
        public byte quantityBackOrdered
        {
            get
            {
                return this.quantityBackOrderedField;
            }
            set
            {
                this.quantityBackOrderedField = value;
            }
        }

        /// <remarks/>
        public byte quantityCanceled
        {
            get
            {
                return this.quantityCanceledField;
            }
            set
            {
                this.quantityCanceledField = value;
            }
        }

        /// <remarks/>
        public byte quantityOrdered
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
        public byte quantityShippable
        {
            get
            {
                return this.quantityShippableField;
            }
            set
            {
                this.quantityShippableField = value;
            }
        }

        /// <remarks/>
        public float rateExchangeOverride
        {
            get
            {
                return this.rateExchangeOverrideField;
            }
            set
            {
                this.rateExchangeOverrideField = value;
            }
        }

        /// <remarks/>
        public object reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public headerDetailRelatedOrder relatedOrder
        {
            get
            {
                return this.relatedOrderField;
            }
            set
            {
                this.relatedOrderField = value;
            }
        }

        /// <remarks/>
        public headerDetailShipTo shipTo
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
        public byte shipmentId
        {
            get
            {
                return this.shipmentIdField;
            }
            set
            {
                this.shipmentIdField = value;
            }
        }

        /// <remarks/>
        public headerDetailSoldTo soldTo
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
        public ushort statusCodeLast
        {
            get
            {
                return this.statusCodeLastField;
            }
            set
            {
                this.statusCodeLastField = value;
            }
        }

        /// <remarks/>
        public ushort statusCodeNext
        {
            get
            {
                return this.statusCodeNextField;
            }
            set
            {
                this.statusCodeNextField = value;
            }
        }

        /// <remarks/>
        public byte timePromisedDelivery
        {
            get
            {
                return this.timePromisedDeliveryField;
            }
            set
            {
                this.timePromisedDeliveryField = value;
            }
        }

        /// <remarks/>
        public byte timePromisedOriginal
        {
            get
            {
                return this.timePromisedOriginalField;
            }
            set
            {
                this.timePromisedOriginalField = value;
            }
        }

        /// <remarks/>
        public byte timePromisedShip
        {
            get
            {
                return this.timePromisedShipField;
            }
            set
            {
                this.timePromisedShipField = value;
            }
        }

        /// <remarks/>
        public byte timeRequested
        {
            get
            {
                return this.timeRequestedField;
            }
            set
            {
                this.timeRequestedField = value;
            }
        }

        /// <remarks/>
        public byte timeScheduledPick
        {
            get
            {
                return this.timeScheduledPickField;
            }
            set
            {
                this.timeScheduledPickField = value;
            }
        }

        /// <remarks/>
        public string unitOfMeasureCodeTransaction
        {
            get
            {
                return this.unitOfMeasureCodeTransactionField;
            }
            set
            {
                this.unitOfMeasureCodeTransactionField = value;
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
    public partial class headerDetailCategoryCodesPurchasing
    {

        private byte categoryCode001Field;

        private object categoryCode002Field;

        private string categoryCode003Field;

        private string categoryCode004Field;

        private string categoryCode005Field;

        /// <remarks/>
        public byte categoryCode001
        {
            get
            {
                return this.categoryCode001Field;
            }
            set
            {
                this.categoryCode001Field = value;
            }
        }

        /// <remarks/>
        public object categoryCode002
        {
            get
            {
                return this.categoryCode002Field;
            }
            set
            {
                this.categoryCode002Field = value;
            }
        }

        /// <remarks/>
        public string categoryCode003
        {
            get
            {
                return this.categoryCode003Field;
            }
            set
            {
                this.categoryCode003Field = value;
            }
        }

        /// <remarks/>
        public string categoryCode004
        {
            get
            {
                return this.categoryCode004Field;
            }
            set
            {
                this.categoryCode004Field = value;
            }
        }

        /// <remarks/>
        public string categoryCode005
        {
            get
            {
                return this.categoryCode005Field;
            }
            set
            {
                this.categoryCode005Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailCategoryCodesSales
    {

        private string categoryCode001Field;

        private string categoryCode002Field;

        private string categoryCode003Field;

        private string categoryCode004Field;

        private string categoryCode005Field;

        /// <remarks/>
        public string categoryCode001
        {
            get
            {
                return this.categoryCode001Field;
            }
            set
            {
                this.categoryCode001Field = value;
            }
        }

        /// <remarks/>
        public string categoryCode002
        {
            get
            {
                return this.categoryCode002Field;
            }
            set
            {
                this.categoryCode002Field = value;
            }
        }

        /// <remarks/>
        public string categoryCode003
        {
            get
            {
                return this.categoryCode003Field;
            }
            set
            {
                this.categoryCode003Field = value;
            }
        }

        /// <remarks/>
        public string categoryCode004
        {
            get
            {
                return this.categoryCode004Field;
            }
            set
            {
                this.categoryCode004Field = value;
            }
        }

        /// <remarks/>
        public string categoryCode005
        {
            get
            {
                return this.categoryCode005Field;
            }
            set
            {
                this.categoryCode005Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailDeliverTo
    {

        private byte entityIdField;

        /// <remarks/>
        public byte entityId
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
    public partial class headerDetailDocument
    {

        private headerDetailDocumentDocumentKey documentKeyField;

        /// <remarks/>
        public headerDetailDocumentDocumentKey documentKey
        {
            get
            {
                return this.documentKeyField;
            }
            set
            {
                this.documentKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailDocumentDocumentKey
    {

        private object documentCompanyField;

        private byte documentNumberField;

        private object documentTypeCodeField;

        /// <remarks/>
        public object documentCompany
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

        /// <remarks/>
        public byte documentNumber
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
        public object documentTypeCode
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
    public partial class headerDetailLineBilling
    {

        private headerDetailLineBillingCarrier carrierField;

        private object freightHandlingCodeField;

        private headerDetailLineBillingLinePricing linePricingField;

        private object modeOfTransportField;

        private string paymentInstrumentCodeField;

        private string paymentTermsCodeField;

        private string printMessageCodeField;

        private object subledgerField;

        private object subledgerTypeCodeField;

        private string taxExplanationCodeField;

        private string taxRateAreaCodeField;

        private string taxableCodeField;

        /// <remarks/>
        public headerDetailLineBillingCarrier carrier
        {
            get
            {
                return this.carrierField;
            }
            set
            {
                this.carrierField = value;
            }
        }

        /// <remarks/>
        public object freightHandlingCode
        {
            get
            {
                return this.freightHandlingCodeField;
            }
            set
            {
                this.freightHandlingCodeField = value;
            }
        }

        /// <remarks/>
        public headerDetailLineBillingLinePricing linePricing
        {
            get
            {
                return this.linePricingField;
            }
            set
            {
                this.linePricingField = value;
            }
        }

        /// <remarks/>
        public object modeOfTransport
        {
            get
            {
                return this.modeOfTransportField;
            }
            set
            {
                this.modeOfTransportField = value;
            }
        }

        /// <remarks/>
        public string paymentInstrumentCode
        {
            get
            {
                return this.paymentInstrumentCodeField;
            }
            set
            {
                this.paymentInstrumentCodeField = value;
            }
        }

        /// <remarks/>
        public string paymentTermsCode
        {
            get
            {
                return this.paymentTermsCodeField;
            }
            set
            {
                this.paymentTermsCodeField = value;
            }
        }

        /// <remarks/>
        public string printMessageCode
        {
            get
            {
                return this.printMessageCodeField;
            }
            set
            {
                this.printMessageCodeField = value;
            }
        }

        /// <remarks/>
        public object subledger
        {
            get
            {
                return this.subledgerField;
            }
            set
            {
                this.subledgerField = value;
            }
        }

        /// <remarks/>
        public object subledgerTypeCode
        {
            get
            {
                return this.subledgerTypeCodeField;
            }
            set
            {
                this.subledgerTypeCodeField = value;
            }
        }

        /// <remarks/>
        public string taxExplanationCode
        {
            get
            {
                return this.taxExplanationCodeField;
            }
            set
            {
                this.taxExplanationCodeField = value;
            }
        }

        /// <remarks/>
        public string taxRateAreaCode
        {
            get
            {
                return this.taxRateAreaCodeField;
            }
            set
            {
                this.taxRateAreaCodeField = value;
            }
        }

        /// <remarks/>
        public string taxableCode
        {
            get
            {
                return this.taxableCodeField;
            }
            set
            {
                this.taxableCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailLineBillingCarrier
    {

        private byte entityIdField;

        /// <remarks/>
        public byte entityId
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
    public partial class headerDetailLineBillingLinePricing
    {

        private string adjustmentScheduleCodeField;

        private System.DateTime datePriceEffectiveField;

        private string itemPriceGroupCodeField;

        private object priceCode1Field;

        private object priceCode2Field;

        private object priceCode3Field;

        private uint priceExtendedDomesticField;

        private byte priceExtendedForeignField;

        private decimal priceUnitDomesticField;

        private decimal priceUnitForeignField;

        private string unitOfMeasureCodePricingField;

        /// <remarks/>
        public string adjustmentScheduleCode
        {
            get
            {
                return this.adjustmentScheduleCodeField;
            }
            set
            {
                this.adjustmentScheduleCodeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime datePriceEffective
        {
            get
            {
                return this.datePriceEffectiveField;
            }
            set
            {
                this.datePriceEffectiveField = value;
            }
        }

        /// <remarks/>
        public string itemPriceGroupCode
        {
            get
            {
                return this.itemPriceGroupCodeField;
            }
            set
            {
                this.itemPriceGroupCodeField = value;
            }
        }

        /// <remarks/>
        public object priceCode1
        {
            get
            {
                return this.priceCode1Field;
            }
            set
            {
                this.priceCode1Field = value;
            }
        }

        /// <remarks/>
        public object priceCode2
        {
            get
            {
                return this.priceCode2Field;
            }
            set
            {
                this.priceCode2Field = value;
            }
        }

        /// <remarks/>
        public object priceCode3
        {
            get
            {
                return this.priceCode3Field;
            }
            set
            {
                this.priceCode3Field = value;
            }
        }

        /// <remarks/>
        public uint priceExtendedDomestic
        {
            get
            {
                return this.priceExtendedDomesticField;
            }
            set
            {
                this.priceExtendedDomesticField = value;
            }
        }

        /// <remarks/>
        public byte priceExtendedForeign
        {
            get
            {
                return this.priceExtendedForeignField;
            }
            set
            {
                this.priceExtendedForeignField = value;
            }
        }

        /// <remarks/>
        public decimal priceUnitDomestic
        {
            get
            {
                return this.priceUnitDomesticField;
            }
            set
            {
                this.priceUnitDomesticField = value;
            }
        }

        /// <remarks/>
        public decimal priceUnitForeign
        {
            get
            {
                return this.priceUnitForeignField;
            }
            set
            {
                this.priceUnitForeignField = value;
            }
        }

        /// <remarks/>
        public string unitOfMeasureCodePricing
        {
            get
            {
                return this.unitOfMeasureCodePricingField;
            }
            set
            {
                this.unitOfMeasureCodePricingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailOriginalOrder
    {

        private headerDetailOriginalOrderOriginalOrderKey originalOrderKeyField;

        private decimal documentLineNumberField;

        /// <remarks/>
        public headerDetailOriginalOrderOriginalOrderKey originalOrderKey
        {
            get
            {
                return this.originalOrderKeyField;
            }
            set
            {
                this.originalOrderKeyField = value;
            }
        }

        /// <remarks/>
        public decimal documentLineNumber
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailOriginalOrderOriginalOrderKey
    {

        private object documentCompanyField;

        private object documentNumberField;

        private object documentTypeCodeField;

        /// <remarks/>
        public object documentCompany
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

        /// <remarks/>
        public object documentNumber
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
        public object documentTypeCode
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
    public partial class headerDetailParent
    {

        private uint entityIdField;

        /// <remarks/>
        public uint entityId
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
    public partial class headerDetailProduct
    {

        private string description1Field;

        private string description2Field;

        private headerDetailProductItem itemField;

        private decimal itemVolumeField;

        private decimal itemWeightField;

        private object locationField;

        private object lotNumberField;

        private string unitOfMeasureCodeVolumeField;

        private string unitOfMeasureCodeWeightField;

        private object zoneNumberField;

        /// <remarks/>
        public string description1
        {
            get
            {
                return this.description1Field;
            }
            set
            {
                this.description1Field = value;
            }
        }

        /// <remarks/>
        public string description2
        {
            get
            {
                return this.description2Field;
            }
            set
            {
                this.description2Field = value;
            }
        }

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

        /// <remarks/>
        public decimal itemVolume
        {
            get
            {
                return this.itemVolumeField;
            }
            set
            {
                this.itemVolumeField = value;
            }
        }

        /// <remarks/>
        public decimal itemWeight
        {
            get
            {
                return this.itemWeightField;
            }
            set
            {
                this.itemWeightField = value;
            }
        }

        /// <remarks/>
        public object location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        public object lotNumber
        {
            get
            {
                return this.lotNumberField;
            }
            set
            {
                this.lotNumberField = value;
            }
        }

        /// <remarks/>
        public string unitOfMeasureCodeVolume
        {
            get
            {
                return this.unitOfMeasureCodeVolumeField;
            }
            set
            {
                this.unitOfMeasureCodeVolumeField = value;
            }
        }

        /// <remarks/>
        public string unitOfMeasureCodeWeight
        {
            get
            {
                return this.unitOfMeasureCodeWeightField;
            }
            set
            {
                this.unitOfMeasureCodeWeightField = value;
            }
        }

        /// <remarks/>
        public object zoneNumber
        {
            get
            {
                return this.zoneNumberField;
            }
            set
            {
                this.zoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailProductItem
    {

        private string itemCatalogField;

        private ushort itemIdField;

        private string itemProductField;

        private object itemUPCEANField;

        /// <remarks/>
        public string itemCatalog
        {
            get
            {
                return this.itemCatalogField;
            }
            set
            {
                this.itemCatalogField = value;
            }
        }

        /// <remarks/>
        public ushort itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }

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

        /// <remarks/>
        public object itemUPCEAN
        {
            get
            {
                return this.itemUPCEANField;
            }
            set
            {
                this.itemUPCEANField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailRelatedOrder
    {

        private decimal documentLineNumberField;

        private headerDetailRelatedOrderRelatedOrderKey relatedOrderKeyField;

        /// <remarks/>
        public decimal documentLineNumber
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
        public headerDetailRelatedOrderRelatedOrderKey relatedOrderKey
        {
            get
            {
                return this.relatedOrderKeyField;
            }
            set
            {
                this.relatedOrderKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerDetailRelatedOrderRelatedOrderKey
    {

        private object documentCompanyField;

        private object documentNumberField;

        private object documentTypeCodeField;

        /// <remarks/>
        public object documentCompany
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

        /// <remarks/>
        public object documentNumber
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
        public object documentTypeCode
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
    public partial class headerDetailShipTo
    {

        private uint entityIdField;

        /// <remarks/>
        public uint entityId
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
    public partial class headerDetailSoldTo
    {

        private uint entityIdField;

        /// <remarks/>
        public uint entityId
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
    public partial class headerDetailUserReservedData
    {

        private byte userReservedAmountField;

        private object userReservedCodeField;

        private byte userReservedNumberField;

        private object userReservedReferenceField;

        /// <remarks/>
        public byte userReservedAmount
        {
            get
            {
                return this.userReservedAmountField;
            }
            set
            {
                this.userReservedAmountField = value;
            }
        }

        /// <remarks/>
        public object userReservedCode
        {
            get
            {
                return this.userReservedCodeField;
            }
            set
            {
                this.userReservedCodeField = value;
            }
        }

        /// <remarks/>
        public byte userReservedNumber
        {
            get
            {
                return this.userReservedNumberField;
            }
            set
            {
                this.userReservedNumberField = value;
            }
        }

        /// <remarks/>
        public object userReservedReference
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerForwardedTo
    {

        private uint entityIdField;

        /// <remarks/>
        public uint entityId
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
    public partial class headerInvoicedTo
    {

        private uint entityIdField;

        /// <remarks/>
        public uint entityId
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
    public partial class headerOriginalOrder
    {

        private headerOriginalOrderOriginalOrderKey originalOrderKeyField;

        /// <remarks/>
        public headerOriginalOrderOriginalOrderKey originalOrderKey
        {
            get
            {
                return this.originalOrderKeyField;
            }
            set
            {
                this.originalOrderKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerOriginalOrderOriginalOrderKey
    {

        private object documentCompanyField;

        private object documentNumberField;

        private object documentTypeCodeField;

        /// <remarks/>
        public object documentCompany
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

        /// <remarks/>
        public object documentNumber
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
        public object documentTypeCode
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
    public partial class headerPaidBy
    {

        private uint entityIdField;

        /// <remarks/>
        public uint entityId
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

        /// <remarks/>
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
    public partial class headerShipTo
    {

        private string addressLine1Field;

        private string addressLine2Field;

        private string addressLine3Field;

        private string addressLine4Field;

        private object cityField;

        private string countryCodeField;

        private object countyCodeField;

        private string mailingNameField;

        private string postalCodeField;

        private headerShipToShipTo shipToField;

        private object stateCodeField;

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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
        public object city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string countryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public object countyCode
        {
            get
            {
                return this.countyCodeField;
            }
            set
            {
                this.countyCodeField = value;
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

        /// <remarks/>
        public string postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public headerShipToShipTo shipTo
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
        public object stateCode
        {
            get
            {
                return this.stateCodeField;
            }
            set
            {
                this.stateCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerShipToShipTo
    {

        private string entityIdField;

        private object entityLongIdField;

        private uint entityTaxIdField;

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

        /// <remarks/>
        public object entityLongId
        {
            get
            {
                return this.entityLongIdField;
            }
            set
            {
                this.entityLongIdField = value;
            }
        }

        /// <remarks/>
        public uint entityTaxId
        {
            get
            {
                return this.entityTaxIdField;
            }
            set
            {
                this.entityTaxIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerSoldTo
    {

        private string entityIdField;

        private object entityLongIdField;

        private uint entityTaxIdField;

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

        /// <remarks/>
        public object entityLongId
        {
            get
            {
                return this.entityLongIdField;
            }
            set
            {
                this.entityLongIdField = value;
            }
        }

        /// <remarks/>
        public uint entityTaxId
        {
            get
            {
                return this.entityTaxIdField;
            }
            set
            {
                this.entityTaxIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class headerUserReservedData
    {

        private byte userReservedAmountField;

        private object userReservedCodeField;

        private byte userReservedNumberField;

        private object userReservedReferenceField;

        /// <remarks/>
        public byte userReservedAmount
        {
            get
            {
                return this.userReservedAmountField;
            }
            set
            {
                this.userReservedAmountField = value;
            }
        }

        /// <remarks/>
        public object userReservedCode
        {
            get
            {
                return this.userReservedCodeField;
            }
            set
            {
                this.userReservedCodeField = value;
            }
        }

        /// <remarks/>
        public byte userReservedNumber
        {
            get
            {
                return this.userReservedNumberField;
            }
            set
            {
                this.userReservedNumberField = value;
            }
        }

        /// <remarks/>
        public object userReservedReference
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