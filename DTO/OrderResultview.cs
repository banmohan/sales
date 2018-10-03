using System;
using System.Collections.Generic;

namespace MixERP.Sales.DTO
{
    public sealed class OrderResultview
    {
        public long Id { get; set; }
        public string Supplier { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime ExpectedDate { get; set; }
        public string ReferenceNumber { get; set; }
        public string Terms { get; set; }
        public string InternalMemo { get; set; }
        public string PostedBy { get; set; }
        public string Office { get; set; }
        public string TransactionTs { get; set; }

        public List<OrderDetails> Details { get; set; }
    }

    public sealed class OrderDetails
    {
        public string ItemName { get; set; }
        public string UnitName { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }

    public sealed class OrderSearchView
    {
        public long OrderId { get; set; }
        public string Customer { get; set; }
        public DateTime ValueDate { get; set; }
        public DateTime ExpectedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string ReferenceNumber { get; set; }
        public string Terms { get; set; }
        public string Memo { get; set; }
        public string PostedBy { get; set; }
        public string Office { get; set; }
        public DateTime PostedOn { get; set; }
        public int OfficeId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
        public string Priority { get; set; }
        public bool Cancelled { get; set; }

        public bool IsSold { get; set; }
        public List<OrderDetails> Details { get; set; }
    }
}