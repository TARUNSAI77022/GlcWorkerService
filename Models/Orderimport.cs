using System;
using System.Collections.Generic;

namespace WorkerService1.Models
{
    public partial class Orderimport
    {
        public int Uniqueid { get; set; }
        public double? PoNumber { get; set; }
        public double? NumberOfLineItems { get; set; }
        public double? LineItemLineNumber { get; set; }
        public string? LineItemSku { get; set; }
        public double? LineItemUpc { get; set; }
        public double? LineItemPartnerSku { get; set; }
        public string? LineItemRetailerItemId1 { get; set; }
        public double? LineItemQuantity { get; set; }
        public string? LineItemTitle { get; set; }
        public double? LineItemExpectedCost { get; set; }
        public DateTime? LineItemShipByDate { get; set; }
        public DateTime? LineItemRequestedShipDate { get; set; }
        public double? LineItemConsumerPrice { get; set; }
        public double? LineItemGiftFlag { get; set; }
        public double? LineItemTaxAmount1 { get; set; }
        public string? ShipName { get; set; }
        public string? ShipAttention { get; set; }
        public string? ShipFirstName { get; set; }
        public string? ShipLastName { get; set; }
        public string? ShipCompany { get; set; }
        public string? ShipAddress1 { get; set; }
        public string? ShipAddress2 { get; set; }
        public string? ShipAddress3 { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipRegion { get; set; }
        public double? ShipPostal { get; set; }
        public string? ShipCountry { get; set; }
        public double? ShipPhone { get; set; }
        public string? ShipEmail { get; set; }
        public string? ShipStoreNumber { get; set; }
        public string? ShipCarrier { get; set; }
        public string? ShipMethod { get; set; }
        public string? ShippingServiceLevelCode { get; set; }
        public DateTime? RetailerCreateDate { get; set; }
        public string? OrderType { get; set; }
        public string? Channel { get; set; }
        public double? ConsumerOrderNumber { get; set; }
        public string? BillToName { get; set; }
        public string? BillToAttention { get; set; }
        public string? BillToFirstName { get; set; }
        public string? BillToLastName { get; set; }
        public string? BillToCompany { get; set; }
        public string? BillToAddress1 { get; set; }
        public string? BillToAddress2 { get; set; }
        public string? BillToCity { get; set; }
        public string? BillToRegion { get; set; }
        public string? BillToPostal { get; set; }
        public string? BillToCountry { get; set; }
        public double? BillToPhone { get; set; }
        public string? BillToEmail { get; set; }
        public string? RetailerShipCarrier { get; set; }
        public string? RetailerShipMethod { get; set; }
        public string? RetailerShippingServiceLevelCode { get; set; }
        public double? DscoOrderId { get; set; }
        public string? DscoOrderStatus { get; set; }
        public string? DscoLifecycle { get; set; }
        public double? DscoItemId { get; set; }
        public double? DscoSupplierId { get; set; }
        public string? DscoSupplierName { get; set; }
        public double? DscoRetailerId { get; set; }
        public double? DscoTradingPartnerId { get; set; }
        public string? DscoTradingPartnerParentId { get; set; }
        public string? DscoTradingPartnerName { get; set; }
        public DateTime? DscoCreateDate { get; set; }
        public DateTime? DscoLastUpdateDate { get; set; }
        public string? BusinessRuleCode { get; set; }
    }
}
