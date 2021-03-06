//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunBeam.Domain.Models
{
    using SunBeam.Domain;
    using System;
    using System.Collections.Generic;

    public partial class Stocks: BaseEntity
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> TotalPaid { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public string Date { get; set; }
        public Nullable<decimal> FinalUnitPrice { get; set; }
        public Nullable<decimal> OpeningQuantity { get; set; }
        public decimal Quantity { get; set; }
        public bool StockStutes { get; set; }

        public Nullable<int> SalesId { get; set; }
        public Nullable<int> SalesReturnId { get; set; }
        public Nullable<int> PurcheaseId { get; set; }
        public Nullable<int> PurcheaseReturnId { get; set; }
        public Nullable<int> StockId { get; set; }
    }
}
